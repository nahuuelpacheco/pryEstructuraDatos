using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Ant = Primero;
                clsNodo Aux = Primero;

                while (Aux.Codigo != Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }
                Ant.Siguiente = Aux.Siguiente;
                Aux = Aux.Siguiente;
                Aux.Anterior = Aux;
            }
        }

    }
}
