using RECEPCION.clases;
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
            //consulta si existe la solicitud
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_reservacion from Reservaciones where Id_reservacion in (select Id_reservacion from solicitudes_recepcion_recursoshumanos)";
                cmd.ExecuteNonQuery();
            }
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            String columna1;
            columna1 = Convert.ToString(fila.Cells[3].Value); //obtengo el valor de la columna precio
             /* 
             * //atrapa los datos en variables
             * 
             * if (id_res in tabla solicitud)
             * {
             *      if(estado_solicitud == aprobado){
             *          elimina reserva y devuelve dinero
             *      }else if (solicitud == Rechazado){
             *          Devolucion no aprobada, ¿Desea eliminar?
             *          if(si){eliminar}
             *          else if (no) {
             *              desea modificar?
             *              if(si){Modificar}
             *              else if(no){??}
             *          }
             *      }else {             
             *          //aun no hay respuesta
             *          Message En espera
             *      }
             * }else{
             *      Mandar solicitud
             *      //insert
             * }
            */
        }
    }
}
