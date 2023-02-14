using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Automóviles
{
    class Autos
    {
        public int placa;
        public string marca,modelo,color;

        public Autos()
        {
            placa = 0;
            marca = modelo = color = "";
        }

        public Autos(int placa, string marca,string modelo,string color)
        {
            this.placa = placa; this.marca = marca; this.modelo = modelo; this.color = color;      
        }

        public override string ToString()
        {
            return "AN - "+placa;
        }

    }
}
