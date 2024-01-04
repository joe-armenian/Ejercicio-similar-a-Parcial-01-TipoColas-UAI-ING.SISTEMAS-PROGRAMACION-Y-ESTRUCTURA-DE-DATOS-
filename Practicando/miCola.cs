using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando
{
    public class miCola
    {
       public Nodo Inicio;

         public Nodo _inicio ()
        {
            return Inicio;
        }

        public void AgregarCliente(Nodo unNodo)
        {
            if (Inicio== null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente==null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }


        public void CobrarCliente()
        {
            if (Inicio != null)
            {
                Inicio = Inicio.Siguiente;
            }

        }

        public bool Vacia()
        {
            return Inicio == null;
        }
            

    }
}
