using System;
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
    public partial class frmDatosDesarollador : Form
    {
        public frmDatosDesarollador()
        {
            InitializeComponent();
        }

        private void frmDatosDesarollador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmDatosDesarollador = new frmVentanaPrincipal();
            frmDatosDesarollador.Show();
            this.Close();
        }
    }
}
