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
            int Tel, Tot;
            string id;
            id = dataGridView1.CurrentCell.Value.ToString();  
            Tel =  Convert.ToInt32(this.textBox3.Text);
            Convert.ToInt32(id);
            Tot = 1000;
            
            DatosRes DatosRes = new DatosRes();
            DatosRes.Id_empleado = "1";
            DatosRes.Id_habitacion = id;
            DatosRes.Fecha_reservacion = dateTimePicker1.Value.ToString();
            DatosRes.Fecha_entrada = dateTimePicker1.Value.ToString();
            DatosRes.Fecha_salida = dateTimePicker2.Value.ToString();
            DatosRes.Nombre_cliente = Cliente_nombre_txt.Text;
            DatosRes.Telefono_cliente = Tel;
            DatosRes.Tarjeta_pago = textBox5.Text;
            DatosRes.Total = Tot;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string F_salida =  dateTimePicker2.Value.ToString("dd/MM/yyyy");

            //MessageBox.Show(F_entrada+"_____"+F_salida);

            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-UGHMV4GH;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id_habitacion, No_cuarto, Tipo_habitacion, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%' and Fecha_salida like '" + F_salida +"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            Conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {                
                string id = dataGridView1.CurrentCell.Value.ToString();            
                MessageBox.Show(" "+ id);
            }            
        }
    }
}
