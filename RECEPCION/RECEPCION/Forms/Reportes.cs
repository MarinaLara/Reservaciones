using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using RECEPCION.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado, no_reporte FROM MAN_reporte_limpieza";
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
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Nombre_cliente, Fecha_solicitud, Habitacion, Devolucion, Id_solicitudRH from solicitudes_recepcion_recursoshumanos, Reservaciones where Reservaciones.Id_reservacion = solicitudes_recepcion_recursoshumanos.Id_reservacion";
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

        //falta
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Seleccionar")
            {
                if (comboBox1.SelectedItem == "Mantenimiento")
                {
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado, no_reporte FROM MAN_reporte_limpieza";
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
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select Nombre_cliente, Fecha_solicitud, Habitacion, Devolucion, Id_solicitudRH from solicitudes_recepcion_recursoshumanos, Reservaciones where Reservaciones.Id_reservacion = solicitudes_recepcion_recursoshumanos.Id_reservacion";
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
            if (comboBox2.SelectedItem == "Pendiente")
            {
                using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                {
                    SqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado, no_reporte FROM MAN_reporte_limpieza where estado = 'Pendiente'";
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
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado, no_reporte FROM MAN_reporte_limpieza where estado = 'Atendiendo'";
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
                    cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, estado, no_reporte FROM MAN_reporte_limpieza where estado = 'Finalizado'";
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
                if (comboBox2.SelectedItem == "Aprobado")
                {
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select Nombre_cliente, Fecha_solicitud, Habitacion, Devolucion, Id_solicitudRH from solicitudes_recepcion_recursoshumanos, Reservaciones where Reservaciones.Id_reservacion = solicitudes_recepcion_recursoshumanos.Id_reservacion and Estado_solicitud = 'Aprobado'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                        Conn.Close();
                    }
                }
                else if (comboBox2.SelectedItem == "Rechazado")
                {
                    using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                    {
                        SqlCommand cmd = Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select Nombre_cliente, Fecha_solicitud, Habitacion, Devolucion, Id_solicitudRH from solicitudes_recepcion_recursoshumanos, Reservaciones where Reservaciones.Id_reservacion = solicitudes_recepcion_recursoshumanos.Id_reservacion and Estado_solicitud = 'Rechazado'";
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

        //NO
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

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //PARA GENERAR LOS PDFS
        private void button1_Click(object sender, EventArgs e)
        {
            String columna1, columna2;
            DataGridViewRow fila = dataGridView1.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {
                //ESCOJE A RUTA DONDE GUARDAREMOS EL PDF 
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (comboBox1.SelectedItem == "Mantenimiento")
                    {
                        columna1 = Convert.ToString(fila.Cells[6].Value); //obtengo el valor de la columna 1 (ignorando la columna seleccionar)

                        using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                        {
                            SqlCommand cmd = Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT no_habitacion, fecha, descripcion, costo_daños, no_reporte estado FROM MAN_reporte_limpieza where no_reporte ="+columna1;
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            String perro = dt.Rows[0][0].ToString();
                            int NumRows = dt.Rows.Count;
                            Conn.Close();

                            string filename = save.FileName;
                            System.IO.FileStream fs = new FileStream(filename, FileMode.Create);


                            Document document = new Document(PageSize.A4, 25, 25, 40, 25);

                            PdfWriter writer = PdfWriter.GetInstance(document, fs);

                            document.AddAuthor("Micke Blomquist");
                            document.AddCreator("Sample application using iTextSharp");
                            document.AddKeywords("PDF tutorial education");
                            document.AddSubject("Document subject - Describing the steps creating a PDF document");
                            document.AddTitle("The document title - PDF creation using iTextSharp");

                            // Open the document to enable you to write to the document
                            document.Open();
                           
                            // Creamos la imagen y le ajustamos el tamaño
                            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("D:/Documentos/GitHub/Reservaciones/Imagenes/logo.png");
                            imagen.BorderWidth = 0;
                            imagen.Alignment = Element.ALIGN_RIGHT;
                            imagen.ScaleAbsolute(59f, 59f);

                            PdfPTable head = new PdfPTable(3);
                            head.DefaultCell.BorderWidth = 0;

                            // Insertamos la imagen en el documento
                            head.AddCell(imagen);
                            head.AddCell("");
                            head.AddCell("");                                                                                    
                            
                            document.Add(head);
                            var blackListTextFont = FontFactory.GetFont("Arial", 28);
                            var blackListTextFont2 = FontFactory.GetFont("Arial", 14);

                            // Add a simple and wellknown phrase to the document in a flow layout manner
                            document.Add(new Paragraph("Reporte de Mantenimiento", blackListTextFont));
                            document.Add(new Paragraph(" "));
                            document.Add(new Paragraph(" "));                            

                            PdfPTable table = new PdfPTable(4);

                            //string H = "Habitacion";

                            table.AddCell(new Paragraph("Habitación", blackListTextFont2));
                            table.AddCell(new Paragraph("Fecha", blackListTextFont2));
                            table.AddCell(new Paragraph("Descripción", blackListTextFont2));
                            table.AddCell(new Paragraph("Costo daños", blackListTextFont2));

                           /* for (int i = 0; i < NumRows; i++)
                            {*/
                            table.AddCell(dt.Rows[0][0].ToString());
                            table.AddCell(dt.Rows[0][1].ToString());
                            table.AddCell(dt.Rows[0][2].ToString());
                            table.AddCell(dt.Rows[0][3].ToString());
                            //}

                            
                            document.Add(table);
                            // Close the document
                            document.Close();
                            // Close the writer instance
                            writer.Close();
                            // Always close open filehandles explicity
                            fs.Close();
                        }
                    }
                    else if (comboBox1.SelectedItem == "R. H.")
                    {
                        //
                        columna2 = Convert.ToString(fila.Cells[5].Value); //obtengo el valor de la columna 1 (ignorando la columna seleccionar)

                        using (SqlConnection Conn = Conexion.ObtnerCOnexion())
                        {
                            SqlCommand cmd = Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select Nombre_cliente, Fecha_solicitud, Habitacion, Devolucion, Id_solicitudRH from solicitudes_recepcion_recursoshumanos, Reservaciones where Reservaciones.Id_reservacion = solicitudes_recepcion_recursoshumanos.Id_reservacion and Id_solicitudRH = "+columna2;
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            String perro = dt.Rows[0][0].ToString();
                            int NumRows = dt.Rows.Count;
                            Conn.Close();

                            string filename = save.FileName;
                            System.IO.FileStream fs = new FileStream(filename, FileMode.Create);


                            Document document = new Document(PageSize.A4, 25, 25, 40, 25);

                            PdfWriter writer = PdfWriter.GetInstance(document, fs);

                            document.AddAuthor("Micke Blomquist");
                            document.AddCreator("Sample application using iTextSharp");
                            document.AddKeywords("PDF tutorial education");
                            document.AddSubject("Document subject - Describing the steps creating a PDF document");
                            document.AddTitle("The document title - PDF creation using iTextSharp");

                            // Open the document to enable you to write to the document
                            document.Open();

                            // Creamos la imagen y le ajustamos el tamaño
                            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("D:/Documentos/GitHub/Reservaciones/Imagenes/logo.png");
                            imagen.BorderWidth = 0;
                            imagen.Alignment = Element.ALIGN_RIGHT;
                            imagen.ScaleAbsolute(59f, 59f);

                            PdfPTable head = new PdfPTable(3);
                            head.DefaultCell.BorderWidth = 0;

                            // Insertamos la imagen en el documento
                            head.AddCell(imagen);
                            head.AddCell("");
                            head.AddCell("");

                            document.Add(head);
                            var blackListTextFont = FontFactory.GetFont("Arial", 28);
                            var blackListTextFont2 = FontFactory.GetFont("Arial", 14);

                            // Add a simple and wellknown phrase to the document in a flow layout manner
                            document.Add(new Paragraph("Reporte de solicitud de cancelación", blackListTextFont));
                            document.Add(new Paragraph(" "));
                            document.Add(new Paragraph(" "));

                            PdfPTable table = new PdfPTable(4);

                            //string H = "Habitacion";

                            table.AddCell(new Paragraph("Cliente", blackListTextFont2));
                            table.AddCell(new Paragraph("Fecha", blackListTextFont2));
                            table.AddCell(new Paragraph("Habitación", blackListTextFont2));
                            table.AddCell(new Paragraph("Devolución", blackListTextFont2));

                            /* for (int i = 0; i < NumRows; i++)
                             {*/
                            table.AddCell(dt.Rows[0][0].ToString());
                            table.AddCell(dt.Rows[0][1].ToString());
                            table.AddCell(dt.Rows[0][2].ToString());
                            table.AddCell(dt.Rows[0][3].ToString());
                            //}


                            document.Add(table);
                            // Close the document
                            document.Close();
                            // Close the writer instance
                            writer.Close();
                            // Always close open filehandles explicity
                            fs.Close();
                        }
                    }
                    
                    
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            prueba Prueb = new prueba();
            Prueb.Show();
        }
    }
}
