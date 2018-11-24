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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }

        DateTime Fecha = DateTime.Today;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearReservación CR = new CrearReservación();
            CR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar ConRes = new Consultar();
            ConRes.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar ConRes = new Consultar();
            ConRes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento MAN = new Mantenimiento();
            MAN.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarES RES = new RegistrarES();
            RES.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearReservación CR = new CrearReservación();
            CR.Show();
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento MAN = new Mantenimiento();
            MAN.Show();
        }

        private void checarInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarES RES = new RegistrarES();
            RES.Show();
        }

    }
}
