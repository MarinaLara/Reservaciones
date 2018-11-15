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
    }
}
