﻿using System;
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

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.solicitudes_recepcion_mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.solicitudes_recepcion_mantenimientoTableAdapter.Fill(this.hotelDataSet.solicitudes_recepcion_mantenimiento);

        }
    }
}
