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
            String varSQL = "SELECT * FROM LIBRO , PAIS ";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO " +
              "WHERE IDPAIS = 3 ";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO " +
                "WHERE IDPAIS = 3" + "AND IDIDIOMA = 2";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";



            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdAutor = 5 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdAutor = 3";
            
            
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro, Idioma WHERE Libro.IdIdioma = Idioma.IdIdioma";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM LIBRO WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM LIBRO WHERE IdIdioma < 5)";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }
    }
}
