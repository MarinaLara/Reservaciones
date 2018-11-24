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
                //cmd.CommandText = "SELECT id_habitacion, No_cuarto, Tipo_habitacion, Precio FROM Habitaciones where Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%')";
                cmd.CommandText = "SELECT id_habitacion, Nombre_cliente, Fecha_entrada FROM Reservaciones where Id_habitacion in (Select Id_habitacion  from Reservaciones where Nombre_cliente like '" + textBox1.Text + "' and Fecha_entrada like '" + F_entrada + "%')";
                //cmd.CommandText = "SELECT id_habitacion, No_cuarto, Tipo_habitacion, Nombre_cliente FROM Reservaciones where Nombre_cliente = '" + textBox1 + "' and Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%')";
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
