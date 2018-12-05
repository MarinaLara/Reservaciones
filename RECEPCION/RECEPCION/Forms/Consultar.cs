using RECEPCION.clases;
using RECEPCION.clases.Insert_Sol_RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECEPCION
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Mantenimiento MAN = new Mantenimiento();
            MAN.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            CrearReservación CR = new CrearReservación();
            CR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar Mod = new Modificar();
            Mod.Show();
        }

        private void disponibilidad_btn_Click(object sender, EventArgs e)
        {
            if (textBox1 == null)
            {
                MessageBox.Show("Por favor ingrese el nombre");
            }
            else
            {
                buscar();
            }
        }
        private void buscar()
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string Nombre = textBox1.ToString();

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT No_cuarto, Nombre_cliente, Fecha_entrada, Fecha_salida, Id_reservacion FROM Reservaciones, Habitaciones where Nombre_cliente like '" + textBox1.Text + "%' and Fecha_entrada like '" + F_entrada + "%' and Reservaciones.Id_habitacion = Habitaciones.Id_habitacion";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            String columna1, Estado;
            int res;
            columna1 = Convert.ToString(fila.Cells[5].Value); //obtengo el valor de la columna precio
            //consulta si existe la solicitud
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_reservacion from Reservaciones where Id_reservacion = "+ columna1 + " and Id_reservacion in (select Id_reservacion from solicitudes_recepcion_recursoshumanos)";
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("Id_reservacion", "Id_reservacion".ToString());
                res = Convert.ToInt32(cmd.ExecuteScalar());       
                Conn.Close();
            }
            
            //No existe
            if (res == 0)
            {
                //mandar solicitud
                //tomar la fecha de hoy
                DateTime Hoy = DateTime.Today;
                string fecha_solicitud = Hoy.ToString("dd/MM/yyyy");
                int Tot, Hab;

                //buscar nhabitacion y total
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select No_cuarto from Reservaciones, Habitaciones where Reservaciones.Id_habitacion = Habitaciones.Id_habitacion and Id_reservacion = " + Convert.ToInt32(columna1);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("No_cuarto", "No_cuarto".ToString());
                    Hab = Convert.ToInt32(cmd.ExecuteScalar()); 

                    cmd.CommandText = "Select Total from Reservaciones where Id_reservacion = " + Convert.ToInt32(columna1);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("Total", "Total".ToString());
                    Tot = Convert.ToInt32(cmd.ExecuteScalar()); 

                    Conn.Close();
                }

                //insert
                DatosSolRH DatosSolRH = new DatosSolRH();
                DatosSolRH.Id_reservacion = Convert.ToInt32(columna1);
                DatosSolRH.Fecha_solicitud = fecha_solicitud;
                DatosSolRH.Habitacion = Hab;
                DatosSolRH.Devolucion = Tot;
                DatosSolRH.Estado_solicitud = "Pendiente";

                int resultado = RegSolRH.InsSolRH(DatosSolRH);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
                //Si existe
            else { 
                //apr o rech
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Estado_solicitud from solicitudes_recepcion_recursoshumanos where Id_reservacion = "+res;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("Estado_solicitud", "Estado_solicitud".ToString());
                    Estado = Convert.ToString(cmd.ExecuteScalar());
                    Conn.Close();
                }

                if (Estado == "Pendiente")
                {
                    MessageBox.Show("Solicitud aún en análisis");
                }
                else if (Estado == "Aprobado")
                {
                    MessageBox.Show("Solicitud aprobada, procediendo a eliminar reservacion");
                    //update 2
                    update2(res);

                    //eliminar
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from chekin_out where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from Reservaciones where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from Disponibilidad_hab where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Eliminado correctamente");
                    }
                }
                else if (Estado == "Rechazado")
                {
                    MessageBox.Show("Solicitud Rechazada, procediendo a eliminar reservacion");
                    //update 2
                    update2(res);
                    
                    //eliminar
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from chekin_out where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from Reservaciones where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from Disponibilidad_hab where Id_reservacion = " + res;
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Eliminado correctamente");
                    }
                }
            }

        }

        public void update2(int res)
        {
            int Total_reserva, Total_caja;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Total from Reservaciones where Id_reservacion = " + res;
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("Total", "Total".ToString());
                Total_reserva = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = "select Total_caja from Caja where Id_caja = 1";
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("Total_caja", "Total_caja".ToString());
                Total_caja = Convert.ToInt32(cmd.ExecuteScalar());
                Conn.Close();
            }

            Total_caja = Total_caja - Total_reserva;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Caja set Total_caja =  " + Total_caja + "where Id_caja = 1";
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
