﻿using intentoRECEPCION1.clases;
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
    public partial class RegistrarES : Form
    {
        public RegistrarES()
        {
            InitializeComponent();
            
        }

        //boton volver
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        //boton buscar
        private void button2_Click(object sender, EventArgs e)
        {
            string F_entrada = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            if (textBox1.Text != " ")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Nombre_cliente, Fecha_entrada, Fecha_salida, Cin, Cout, chekin_out.Id_reservacion from Reservaciones, chekin_out where Reservaciones.Id_reservacion = chekin_out.Id_reservacion and Nombre_cliente like '" + textBox1.Text + "%' and Fecha_entrada like '" + F_entrada + "%'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    Conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar campos");
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void Enviar_Click(object sender, EventArgs e)
        {
            //tomar la fecha de hoy
            DateTime Hoy = DateTime.Today;
            Convert.ToString(Hoy);
            string columna1;
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            columna1 = Convert.ToString(fila.Cells[4].Value); //obtengo el valor de la columna precio

            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem == "Entrada")
                {
                    if (columna1 == "") //vacio
                    {
                        //insert
                        /*DatosRes DatosRes = new DatosRes();
                        DatosRes.Id_empleado = "1";
                        

                        int resultado = Regreserva.Agregar(DatosRes);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("Entrada anteriormente registrada");
                    }
                }
                else if (comboBox1.SelectedItem == "Salida")
                {
                    
                }
            }
        }
    }
}
