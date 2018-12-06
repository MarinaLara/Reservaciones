using RECEPCION.clases;
using System;
using RECEPCION.clases.Habitaciones;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECEPCION.Forms
{
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet1.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.hotelDataSet1.Habitaciones);
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Habitaciones";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Conn.Close();
            }
        }
        //Botón 3 para cerrar la ventana
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }
        //Botón 1 para insertar habitaciones
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo de numero de habitación");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo de tipo de habitación");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo del precio de la habitación");
            }
            else
            {
                guardar();
            }
        }
        private void guardar()
        {
            //insert
            DatHabitacion DatHabitacion = new DatHabitacion();
            DatHabitacion.No_cuarto = textBox1.Text;
            DatHabitacion.Tipo_habitacion = comboBox1.Text;
            DatHabitacion.Estado_habitacion = "Limpia";
            DatHabitacion.Disponibilidad = "Disponible";
            DatHabitacion.Precio = textBox3.Text;

            int resultado = Insertacion.Agregar(DatHabitacion);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Botón 5 para consultar habitaciones
        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Habitaciones";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Conn.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //Botón 2 para modificacion de habitaciones
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo de numero de habitación");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo de tipo de habitación");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo del precio de la habitación");
            }
            else
            {
                update();
            }
        }
        private void update()
        {

            int id;
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            id = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la columna id

            Modhabi Modhabi = new Modhabi();
            Modhabi.Id_habitacion = id;
            Modhabi.No_cuarto = textBox1.Text;
            Modhabi.Tipo_habitacion = comboBox1.Text;
            Modhabi.Estado_habitacion = "Limpia";
            Modhabi.Disponibilidad = "Disponible";
            Modhabi.Precio = textBox3.Text;

            int resultado = Updhabi.Agregar(Modhabi);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Botón 4 para eliminacion de habitaciones
        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            id = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la columna id
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Habitaciones where Id_habitacion = " + id;
                cmd.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Eliminado correctamente");
            }
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Mantenimiento man = new Mantenimiento();
            man.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes Rep = new Reportes();
            Rep.Show();
        }
    }
}
