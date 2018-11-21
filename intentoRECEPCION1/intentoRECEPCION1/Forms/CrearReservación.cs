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
    public partial class CrearReservación : Form
    {
        public CrearReservación()
        {
            InitializeComponent();
        }        

        //metodo para insertar, se manda a llamar en el button2_click
        private void guardar()
        {
            //variables
            int Tot, dias, colprecio;
            string id, columna1;
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            //tomar la fecha de hoy
            DateTime Hoy = DateTime.Today;
            string fecha_reserva = Hoy.ToString("dd/MM/yyyy");

            //conversiones        
            columna1 = Convert.ToString(fila.Cells[3].Value); //obtengo el valor de la columna precio
            id = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la columna id
            colprecio = Convert.ToInt32(columna1);
            Convert.ToInt32(id);

            //Calcular la cantidad de dias
            TimeSpan ts = dateTimePicker2.Value - dateTimePicker1.Value;
            dias = (int)ts.TotalDays;           
            
            //operaciones
            Tot = dias * colprecio;

            //insert
            DatosRes DatosRes = new DatosRes();
            DatosRes.Id_empleado = "1";
            DatosRes.Id_habitacion = id;
            DatosRes.Fecha_reservacion = fecha_reserva;
            DatosRes.Fecha_entrada = dateTimePicker1.Value.ToString();
            DatosRes.Fecha_salida = dateTimePicker2.Value.ToString();
            DatosRes.Nombre_cliente = Cliente_nombre_txt.Text;
            DatosRes.Telefono_cliente = textBox3.Text;
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
       
        //menu cerrar secion //salir
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //carga datagrid
        private void CrearReservación_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            //this.habitacionesTableAdapter.Fill(this.hotelDataSet.Habitaciones);            
        }

        //boton crear reserva
        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1)
            {
                string columna1, columna2;
       
                DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

                columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la columna id

                columna2= Convert.ToString(fila.Cells[3].Value); //obtengo el valor de la  columna precio
            }            
        }

        //boton volver
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        //Consultar disponibilidad
        private void disponibilidad_btn_Click(object sender, EventArgs e)
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string F_salida = dateTimePicker2.Value.ToString("dd/MM/yyyy");

            using (SqlConnection Conn = Conexion.ObtnerCOnexion()) 
            { 
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id_habitacion, No_cuarto, Tipo_habitacion, Precio FROM Habitaciones where Tipo_habitacion = '" + cbx_tipo_hab.SelectedItem + "' and not Id_habitacion in (Select Id_habitacion  from Disponibilidad_hab where Fecha_entrada like '" + F_entrada + "%' and Fecha_salida like '" + F_salida + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Conn.Close();
            }
        }
    }
}
