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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();


        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                Lista.Agregar(ObjNodo);
                Lista.Recorrer(dgvListaD);
                Lista.RecorrerDes(dgvListaD);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbLista);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            {
                if (Lista.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cmbLista.Text);
                    Lista.Eliminar(x);
                    Lista.Recorrer(dgvListaD);
                    Lista.RecorrerDes(dgvListaD);
                    Lista.Recorrer(lstListaDoble);
                    Lista.Recorrer();
                }
                else
                {
                    MessageBox.Show("La lista está vacia");
                    cmbLista.Items.Clear();
                }
            }

        }

        private void rbAscendente_CheckedChanged_1(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvListaD);
        }

        private void rbDescendente_CheckedChanged_1(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvListaD);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmListaDoble = new frmVentanaPrincipal();
            frmListaDoble.Show();
            this.Close();

        }
    }
}