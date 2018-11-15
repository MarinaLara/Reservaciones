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
            Tel =  Convert.ToInt32(this.textBox3.Text);            
            Tot = 1500;

            DatosRes DatosRes = new DatosRes();
            DatosRes.Id_empleado = "1";
            DatosRes.Id_habitacion = "3";
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
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter1.Fill(this.hotelDataSet.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'reservacionesDataSet.habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.reservacionesDataSet.habitaciones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string holi = dateTimePicker1.Value.ToShortDateString();
            string holi2 = dateTimePicker2.Value.ToShortDateString();

            //dateTimePicker1.Value = DateTime.ParseExact("dd/MM/yyyy", dateTimeString,);


            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-UGHMV4GH;Initial Catalog=Hotel;User ID=sa;Password=sasa");
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT No_cuarto, Tipo_habitacion, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada = '17-11-2018' and Fecha_salida = '19-11-2018')";
            //cmd.CommandText = "SELECT No_cuarto, Tipo_habitacion, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like ('" + holi + "%') and Fecha_salida like ('" + holi2 + "%'))";
            //cmd.CommandText = "SELECT No_cuarto, Tipo_habitacion, Disponibilidad FROM Habitaciones where not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like ('" + dateTimePicker1 + "%') and Fecha_salida like ('" + dateTimePicker2 + "%'))";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            Conn.Close();
        }
    }
}
