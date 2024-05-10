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
    public partial class frmCola : Form
      
    {
        public frmCola()
          
       
        {
            InitializeComponent();
        }
        
        clsCola FilaDePersonas = new clsCola();

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(lstCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombre.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblTramite.Text = FilaDePersonas.Primero.Codigo.ToString();
                FilaDePersonas.Elminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmCola = new frmVentanaPrincipal();
            frmCola.Show();
            this.Close();
        }
    }
}
