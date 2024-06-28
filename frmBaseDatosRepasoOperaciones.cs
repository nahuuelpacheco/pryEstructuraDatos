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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            clsBaseDatos objBadeDatos = new clsBaseDatos();
            String consulta = "SELECT * FROM Libro";
            switch (cmbOperaciones.SelectedIndex)
            {
                case 0://UNION 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Union entre libros del pais 5 y 1";

                    consulta =
                        "select * from Libro where idpais = 5 " +
                        "union " +
                        "select * from Libro where idpais = 1";

                    break;
                case 1://UNION 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Union entre libros de los los idiomas 7 y 3";

                    consulta =
                        "select titulo, ididioma, año from Libro where ididioma = 7 " +
                        "union " +
                        "select titulo, ididioma, año from Libro where ididioma = 3";
                    break;
                case 2://INTERSECCIÓN 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Libros donde el idioma sea igual a 4";
                    // corregir
                    consulta =
                        "select * from libro where ididioma " +
                        "in " +
                        "(select distinct ididioma from libro where ididioma = 4)";
                    break;
                case 3://INTERSECCION 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Libros donde la cantidad es mayor a 10";
                    //corregir
                    consulta =
                        "select * from libro where cantidad " +
                        "in " +
                        "(select distinct cantidad from libro where cantidad > 10)";
                    break;
                case 4://DIFERENCIA 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Elimina los autores mayores a 10";

                    consulta =
                        "select * from libro where idautor " +
                        "not in " +
                        "(select distinct idautor from libro where idautor > 10) ";
                    break;
                case 5://DIFERENCIA 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Elimina los libros mayores a 7";

                    consulta =
                        "select * from libro where idlibro " +
                        "not in " +
                        "(select distinct idlibro from libro where idlibro > 7) ";
                    break;
                case 6://SELECCION SIMPLE 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los libros que cuya cantidad es igual a 5";

                    consulta =
                        "select idlibro, titulo, idautor, cantidad from libro where cantidad = 5 ";
                    break;
                case 7://SELECCION SIMPLE 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los los libros que cuyo precio es igual a 700 ";

                    consulta =
                        "select idlibro, titulo, precio from libro where precio = 700 ";
                    break;
                case 8://SEL. MULTIATRIBUTO X INTERSECCION 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los los libros que el precio es mayor a 700 y el pais son menores a 5 ";

                    consulta =
                        "select idlibro, titulo, idpais, precio from libro where precio > 700 and idpais < 5";
                    break;
                case 9://SEL. MULTIATRIBUTO X INTERSECCION 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los los libros que el precio es mayor a 700, el pais menor a 5 y cantidad mayor a 5 ";

                    consulta =
                        "select * from libro where precio > 700 and idpais < 5 and cantidad > 5";
                    break;
                case 10://SEL. MULTIATRIBUTO X CONVOLUCION 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los libros de dos tablas virtuales(no existentes) con la condicion de que el libro sea menor a 20 y su precio sea menor a 200 ";

                    consulta =
                        "select * from (select * from libro as T1 where T1.idlibro < 20) as T2 where T2.precio < 200";
                    break;
                case 11://SEL. MULTIATRIBUTO X CONVOLUCION 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Selecciona los libros de dos tablas virtuales(no existentes) con la condicion de que el autor sea menor a 10 y el idioma del libro sea menor a 4 ";

                    consulta =
                        "select * from (select * from libro as T1 where T1.idautor < 10) as T2 where T2.ididioma < 4";
                    break;
                case 12://ORDEN 1 
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Ordena los libros de mayor a menor segun el precio";

                    consulta =
                        "select idlibro, titulo, idautor, precio from libro order by precio desc";
                    break;
                case 13://ORDEN 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Ordena los libros de menor a mayor segun el precio";

                    consulta =
                        "select idlibro, titulo, idautor, precio from libro order by precio asc";
                    break;
                case 14://PROYECCION X UN ATRIBUTO 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con un solo atributo/columna para ver solamente los titulos de los libros";

                    consulta =
                        "select titulo from libro ";
                    break;
                case 15://PROYECCION X UN ATRIBUTO 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con un solo atributo/columna para ver solamente los años de lanzamiento de los libros";

                    consulta =
                        "select año from libro ";
                    break;
                case 16://PROYECCION MULTIATRIBUTO 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con multiples atributo/columna para ver los numeros de indetificacion de autores y sus nombres de la tabla Autores";

                    consulta =
                        "select idautor as ID, Nombre from Autor ";
                    break;
                case 17://PROYECCION MULTIATRIBUTO 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con multiples atributo/columna para ver los numeros de indetificacion de libros, titulos, precio y la cantidad de la tabla Libros";

                    consulta =
                        "select idLibro as ID, Titulo, Precio, Cantidad from Libro ";
                    break;
                case 18://JUNTAR 1
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Consulta que realiza una combinación implícita (combinación de estilo antiguo) entre las tablas LIBRO y AUTOR";

                    consulta =
                        "SELECT Titulo, Año, Nombre " +
                        "FROM LIBRO, AUTOR " +
                        "WHERE Libro.idAutor = Autor.idAutor ";
                    break;
                case 19://JUNTAR 2
                    lblDescripcion.Text = cmbOperaciones.Text + ": " + "Consulta que realiza una combinación implícita (combinación de estilo antiguo) entre las tablas LIBRO y PAIS";

                    consulta =
                        "SELECT Titulo, Año, Nombre as Pais " +
                        "FROM LIBRO, PAIS " +
                        "WHERE Libro.idPais = Pais.idPais";
                    break;
            }
           
            objBadeDatos.Listar(dgvGrilla, consulta);
        }
    }
}
