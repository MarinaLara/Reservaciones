﻿using RECEPCION.clases;
using RECEPCION.clases.Insert_Reserva;
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
    public partial class CrearReservación : Form
    {
        public CrearReservación()
        {
            InitializeComponent();
            //tomar la fecha de hoy
            DateTime Hoy = DateTime.Today;
            Convert.ToString(Hoy);

            dateTimePicker1.Value = Hoy;
            dateTimePicker2.Value = Hoy;
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

            update1(Tot);

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

        public void update1(int Tot)
        {
            int Total_caja;
            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Total_caja from Caja";
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("Total_caja", "Total_caja".ToString());
                Total_caja = Convert.ToInt32(cmd.ExecuteScalar()); 
                Conn.Close();
            }

            Tot = Tot + Total_caja;

            using (SqlConnection Conn = Conexion.ObtnerCOnexion())
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Caja set Total_caja =  " + Tot + "where Id_caja = 1";
                cmd.ExecuteNonQuery();   
                Conn.Close();
            }
        }

        //menu cerrar sesion //salir
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //boton crear reserva
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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
                    MessageBox.Show("Favor de realizar el pago en efectivo");
                    guardar();
                    //crear metodo para insertar chekin_out mandando a buscar el ultimo id insertado y tomarlo para insertarlo en la tabla
                    buscar_ultimo_id_reservacion();

                    this.Close();
                    Inicio Regreso = new Inicio();
                    Regreso.Show();
                }
            }
            else //si no esta seleccionado
            {
                if (Cliente_nombre_txt.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    guardar();
                    //crear metodo para insertar chekin_out mandando a buscar el ultimo id insertado y tomarlo para insertarlo en la tabla
                    buscar_ultimo_id_reservacion();

                    this.Close();
                    Inicio Regreso = new Inicio();
                    Regreso.Show();
                }
            }
        }
        
        //
        public void buscar_ultimo_id_reservacion() 
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

            //insert
            DatosRes DatosRes = new DatosRes();
            DatosRes.Id_reservacion = res;

            int resultado = Insertchekinout.Agregar(DatosRes);
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
            if (cbx_tipo_hab.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un tipo");
            }
            else 
            {
                buscar();                
            }
        }

        private void buscar()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1)
            {

                string columna1;
                DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
                int colprecio, dias, Tot;
                string id;

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

                label4.Text = Convert.ToString(Tot);

            }
        }

        //reset datagrid por cambio de fecha
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (cbx_tipo_hab.SelectedItem != null)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
                label4.Text = "0";
                cbx_tipo_hab.SelectedItem = null;                
            }
        }

        //Validaciones campos
        private void Cliente_nombre_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) 
            { 
                e.Handled = false; 
            }
            else if (Char.IsControl(e.KeyChar)) 
            { 
                e.Handled = false; 
            }
            else if (Char.IsSeparator(e.KeyChar)) 
            { 
                e.Handled = false; 
            }
            else 
            { 
                e.Handled = true; 
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CrearReservación_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSetServidor1.Reservaciones' Puede moverla o quitarla según sea necesario.
            //this.reservacionesTableAdapter.Fill(this.hotelDataSetServidor1.Reservaciones);

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Consultar Con = new Consultar();
            Con.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Modificar Mod = new Modificar();
            Mod.Show();
        }

    }
}
