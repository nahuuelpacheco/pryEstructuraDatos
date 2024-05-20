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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();
        
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
;        }

        private void dgvDatosBaseDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO , AÑO " +
                  "FROM LIBRO " + "ORDER BY 1 DESC";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {

        }
    }
}
