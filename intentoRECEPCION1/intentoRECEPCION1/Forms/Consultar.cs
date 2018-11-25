using intentoRECEPCION1.clases;
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
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Reservaciones' Puede moverla o quitarla según sea necesario.
            //this.reservacionesTableAdapter.Fill(this.hotelDataSet.Reservaciones);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //ODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            // this.habitacionesTableAdapter.Fill(this.hotelDataSet.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter1.Fill(this.hotelDataSet.Habitaciones);


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
                cmd.CommandText = "SELECT No_cuarto, Nombre_cliente, Fecha_entrada, Fecha_salida FROM Reservaciones, Habitaciones where Nombre_cliente like '" + textBox1.Text + "%' and Fecha_entrada like '" + F_entrada + "%' and Reservaciones.Id_habitacion = Habitaciones.Id_habitacion";
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
    }
}
