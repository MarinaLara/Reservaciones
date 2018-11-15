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

namespace intentoRECEPCION1
{
    public partial class CrearReservación : Form
    {
        public CrearReservación()
        {
            InitializeComponent();
        }

        public static SqlConnection ObtnerCOnexion()
        {
            //SqlConnection Conn = new SqlConnection(@"Data Source=192.168.1.65;Initial Catalog=Hotel;User ID=servidor;Password=servidor123");
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-UGHMV4GH;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            Conn.Open();
            return Conn;
        }

        private void guardar()
        {
            DatosRes DatosRes = new DatosRes();
            DatosRes.Fecha_entrada = dateTimePicker1.Text;
            DatosRes.Fecha_salida = dateTimePicker2.Text;
            DatosRes.Nombre_cliente =  Cliente_nombre_txt.Text;
            //DatosRes.Id_empleado = textBox1.Text;
            //DatosRes.Id_habitacion = textBox1.Text;

            int resultado = Regreserva.Agregar(DatosRes);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearReservación CR = new CrearReservación();
            CR.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CrearReservación_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet1.Habitaciones' Puede moverla o quitarla según sea necesario.
            this.habitacionesTableAdapter2.Fill(this.hotelDataSet1.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter1.Fill(this.hotelDataSet.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'reservacionesDataSet.habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.reservacionesDataSet.habitaciones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-UGHMV4GH;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Id_habitacion No_cuarto, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada = '" + dateTimePicker1 + "' and Fecha_salida = '" + dateTimePicker2 + "'";
            cmd.CommandText = "SELECT Id_habitacion No_cuarto, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada = '2018-11-17' and Fecha_salida = '2018-11-19'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            Conn.Close();
        }
    }
}
