using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Automóviles
{
    class Nodo
    {
        public Autos autos;
        public Nodo izq, der;


        public Nodo()
        {
            autos = new Autos();
            izq = der = null;
        }

        public Nodo(Autos a)
        {
            autos = a;
            izq = der = null;
        }

    }
}
