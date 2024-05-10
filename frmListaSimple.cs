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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero !=null)
            {
                Int32 x = Convert.ToInt32(cmbLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaS);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cmbLista);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                cmbLista.Items.Clear();
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer();
            Lista.Recorrer(dgvListaS);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cmbLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmListaSimple = new frmVentanaPrincipal();
            frmListaSimple.Show();
            this.Close();
        }
    }
}
