﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarollador frmDatosDesarollador = new frmDatosDesarollador();
            frmDatosDesarollador.Show();
             this.Hide();
       
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.Show();
            this.Hide();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.Show();
            this.Hide();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.Show();
            this.Hide();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaDoble = new frmListaDoble();
            frmListaDoble.Show();
            this.Hide();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbolBinario = new frmArbolBinario();
            frmArbolBinario.Show();
            this.Hide();
        }
    }
}
