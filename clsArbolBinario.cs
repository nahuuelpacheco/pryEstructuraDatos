using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        //Creo el campo inicial del arbol, lo llamamos raiz

        private clsNodo PrimeroNodo;

        //Creo la unica propiedades que necesito

        public clsNodo Raiz
        {
            get { return PrimeroNodo; }
            set { PrimeroNodo = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }

                }
                //Afuera del while 
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;

                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        public void RecorrerAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        public void RecorrerDesc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDesc(Grilla, Raiz);
        }
        private void InOrdenDesc(DataGridView Dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDesc(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenDesc(Dgv, R.Izquierdo);
        }

        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Dgv, R.Derecho);
        }

        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        private void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        public void RecorrerDesc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDesc(Lista, Raiz);
        }
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }

        public void RecorrerPre(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }
        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }

        public void RecorrerPost(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }
        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }

        public void RecorrerAsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        private void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(cmb, R.Izquierdo);
            }
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(cmb, R.Derecho);
            }
        }

        public void RecorrerDesc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDesc(Combo, Raiz);
        }
        private void InOrdenDesc(ComboBox cmb, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(cmb, R.Derecho);
            }
            cmb.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(cmb, R.Izquierdo);
            }
        }

        public void RecorrerPre(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }
        public void PreOrden(ComboBox cmb, clsNodo R)
        {
            cmb.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(cmb, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(cmb, R.Derecho);
            }
        }

        public void RecorrerPost(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }
        public void PostOrden(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(cmb, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(cmb, R.Derecho);
            }
            cmb.Items.Add(R.Codigo);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo aux = Raiz;
            while (aux != null)
            {
                if (cod == aux.Codigo) break;
                if (cod < aux.Codigo) aux = aux.Izquierdo;
                else aux = aux.Derecho;
            }
            return aux;
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }


        public void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, Codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

    }
}



