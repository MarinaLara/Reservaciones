using intentoRECEPCION1.clases.Insert_Mant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intentoRECEPCION1
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio Regreso = new Inicio();
            Regreso.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Consultar ConRes = new Consultar();
            ConRes.Show();
        }

        private void enviar_btn_Click(object sender, EventArgs e)
        {
            if (ins_habit_txt.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (cbx_solicitud.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //tomar la fecha de hoy
                DateTime Hoy = DateTime.Today;
                string fecha_reserva = Hoy.ToString("dd/MM/yyyy");

                //inserta
                DatosMant DatosMant = new DatosMant();
                DatosMant.Fecha_solicitud = fecha_reserva;
                DatosMant.Solicita = Convert.ToString(cbx_solicitud.SelectedItem);
                DatosMant.Habitacion = Convert.ToInt32(ins_habit_txt.Text);
                DatosMant.Estado_solicitud = "Pendiente";

                int resultado = RegSolMant.Insert_Mantenimiento(DatosMant);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.solicitudes_recepcion_mantenimiento' Puede moverla o quitarla según sea necesario.
            this.solicitudes_recepcion_mantenimientoTableAdapter.Fill(this.hotelDataSet.solicitudes_recepcion_mantenimiento);

        }
    }
}
