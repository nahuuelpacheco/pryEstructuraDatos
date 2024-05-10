using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    class clsListaDoble
    {
        //Declaro los dos campos
        private clsNodo pri;
        private clsNodo ult;
        
        //Declaro las dos propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Primero ==  null)
            {
                Primero = Nvo;
                Ultimo = Nvo;

            }
            else
            {
                if(Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        clsNodo Sig = Primero;
                        clsNodo Ant = Primero;
                        while (Sig.Codigo < Nvo.Codigo)
                        {
                            Ant = Sig;
                            Sig = Sig.Siguiente;
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Sig;
                        Sig.Anterior = Nvo;
                        Nvo.Anterior = Ant;
                    }

            
                    
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Ultimo.Codigo == Codigo)
                {
                    Ultimo = Ultimo.Anterior;
                    Ultimo.Siguiente = null;
                }
                else
                {
                    clsNodo Ant = Primero;
                    clsNodo Aux = Primero;
                    while (Aux.Codigo < Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }
                    Ant.Siguiente = Aux.Siguiente;
                    Aux = Aux.Siguiente;
                    Aux.Anterior = Ant;
                }

            }


        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Codigo);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
