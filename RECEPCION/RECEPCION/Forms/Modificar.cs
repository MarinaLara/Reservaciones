using System;
using RECEPCION.clases;
using RECEPCION.clases.Update_Reserva;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECEPCION
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Disponibilidad_hab' Puede moverla o quitarla según sea necesario.
            //this.disponibilidad_habTableAdapter.Fill(this.hotelDataSet.Disponibilidad_hab);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Reservaciones' Puede moverla o quitarla según sea necesario.
            //this.reservacionesTableAdapter.Fill(this.hotelDataSet.Reservaciones);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.hotelDataSet.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.hotelDataSet.Habitaciones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Consultar ConRes = new Consultar();
            ConRes.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Cliente_nombre_txt.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Update();
                //crear metodo para insertar chekin_out mandando a buscar el ultimo id insertado y tomarlo para insertarlo en la tabla
                buscar_id_reservacion();

                this.Close();
                Inicio Regreso = new Inicio();
                Regreso.Show();
            }
        }
        public void Update()
        {
            //variables
            int Tot, dias, colprecio;
            string id, columna1, columna2, dispo;
            DataGridViewRow filaMod = dataGridView2.CurrentRow;  // obtengo la fila seleccionada de la habitacion para la modificación 
            DataGridViewRow filaCon = dataGridView1.CurrentRow; // obtengo la fila seleccionada de la consulta para conseguir el ID de la reserva
            DataGridViewRow filaDis = dataGridView3.CurrentRow; //Obtengo el identificador de la antigua reservación
            
            //tomar la fecha de hoy
            DateTime Hoy = DateTime.Today;
            string fecha_reserva = Hoy.ToString("dd/MM/yyyy");
            
            //conversiones        
            columna1 = Convert.ToString(filaMod.Cells[3].Value); //obtengo el valor de la columna precio
            id = Convert.ToString(filaMod.Cells[0].Value); //obtengo el valor de la columna id
            colprecio = Convert.ToInt32(columna1);
            Convert.ToInt32(id);
            columna2 = Convert.ToString(filaCon.Cells[1].Value); //Obtengo el ID de reservacion
            Convert.ToInt32(columna2);
            dispo = Convert.ToString(filaDis.Cells[0].Value); // Obtengo el ID disponibilidad anterior
            Convert.ToInt32(dispo);
            //Calcular la cantidad de dias
            TimeSpan ts = dateTimePicker3.Value - dateTimePicker2.Value;
            dias = (int)ts.TotalDays;

            //operaciones
            Tot = dias * colprecio;

            //update
            Update_Reserva UpdateRes = new Update_Reserva();
            UpdateRes.Id_empleado = "1";
            UpdateRes.Id_habitacion = id;
            UpdateRes.Fecha_reservacion = fecha_reserva;
            UpdateRes.Fecha_entrada = dateTimePicker2.Value.ToString();
            UpdateRes.Fecha_salida = dateTimePicker3.Value.ToString();
            UpdateRes.Nombre_cliente = Cliente_nombre_txt.Text;
            UpdateRes.Telefono_cliente = textBox3.Text;
            UpdateRes.Total = Tot;
            UpdateRes.Id_reservacion = columna2;
            UpdateRes.Id_dispo = dispo;


            int resultado = Updeserva.Agregar(UpdateRes);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void buscar_id_reservacion()
        {
            int res;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id_reservacion from Reservaciones where Id_reservacion = some (select max (Id_reservacion) from Reservaciones)";
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("Id_reservacion", "Id_reservacion".ToString());
                res = Convert.ToInt32(cmd.ExecuteScalar());
                Conn.Close();
            }

            //futuro update
            DatosRes DatosRes = new DatosRes();
            DatosRes.Id_reservacion = res;

            //int resultado = Insertchekinout.Agregar(DatosRes);
        }
        
        private void disponibilidad_btn_Click(object sender, EventArgs e) //Botón que busca si existe la reserva solicitada
        {
            if (Cliente_nombre_txt == null)
            {
                MessageBox.Show("Por favor ingrese el nombre");
            }
            else
            {
                buscarReserva();
                buscarDispo();
            }
        }
        private void buscarReserva()
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string Nombre = Cliente_nombre_txt.ToString();
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT No_cuarto, Nombre_cliente, Fecha_entrada, Fecha_salida, Id_reservacion FROM Reservaciones, Habitaciones where Nombre_cliente like '" + Cliente_nombre_txt.Text + "%' and Fecha_entrada like '" + F_entrada + "%' and Reservaciones.Id_habitacion = Habitaciones.Id_habitacion";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Conn.Close();
            }
        }
        private void buscarDispo()
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string Nombre = Cliente_nombre_txt.ToString();
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id_dispo, Id_habitacion, Fecha_entrada, Fecha_salida, Estado FROM Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
                Conn.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e) //Botón que busca si hay habitaciones disponibles
        {
            if (cbx_tipo_hab.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un tipo");
            }
            else
            {
                buscarHabitacion();
            }
        }
        private void buscarHabitacion()
        {
            string F_entrada = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            string F_salida = dateTimePicker3.Value.ToString("dd/MM/yyyy");

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id_habitacion, No_cuarto, Tipo_habitacion, Precio FROM Habitaciones where Tipo_habitacion = '" + cbx_tipo_hab.SelectedItem + "' and not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%' and Fecha_salida like '" + F_salida + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
                Conn.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 1)
            {

                string columna1;
                DataGridViewRow fila = dataGridView2.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
                int colprecio, dias, Tot;
                string id;

                //conversiones        
                columna1 = Convert.ToString(fila.Cells[3].Value); //obtengo el valor de la columna precio
                id = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la columna id

                colprecio = Convert.ToInt32(columna1);
                Convert.ToInt32(id);

                //Calcular la cantidad de dias
                TimeSpan ts = dateTimePicker3.Value - dateTimePicker2.Value;
                dias = (int)ts.TotalDays;
                //operaciones
                Tot = dias * colprecio;

                label2.Text = Convert.ToString(Tot);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            CrearReservación CR = new CrearReservación();
            CR.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Consultar Con = new Consultar();
            Con.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Mantenimiento Man = new Mantenimiento();
            Man.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           // Reportes Rep = new Reportes();
           // Rep.Show(); ¿?
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
