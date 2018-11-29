using RECEPCION.clases;
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

namespace RECEPCION.Forms
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Mantenimiento")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    Conn.Close();
                }
            }
            else if (comboBox1.SelectedItem == "R. H.")
            {
                //   
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Pendiente")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Pendiente'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    Conn.Close();
                }
            }
            else if (comboBox2.SelectedItem == "Atendiendo")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Atendiendo'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    Conn.Close();
                }
            }
            else if (comboBox2.SelectedItem == "Finalizado")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Finalizado'";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (comboBox1.SelectedItem == "Mantenimiento" && comboBox2.SelectedItem != null)
                {
                    if (comboBox2.SelectedItem == "Pendiente")
                    {
                        using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                        {
                            SqlCommand cmd = Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Pendiente'";
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                            Conn.Close();
                        }
                    }
                    else if (comboBox2.SelectedItem == "Atendiendo")
                    {
                        using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                        {
                            SqlCommand cmd = Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Atendiendo'";
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                            Conn.Close();
                        }
                    }
                    else if (comboBox2.SelectedItem == "Finalizado")
                    {
                        using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                        {
                            SqlCommand cmd = Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado FROM MAN_reporte_limpieza where estado = 'Finalizado'";
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
                else if (comboBox1.SelectedItem == "R. H." && comboBox2.SelectedItem != null)
                {
                    //
                }
            }
        }
    }
}
