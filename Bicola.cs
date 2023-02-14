using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Aplicativo_Automóviles
{
    class Bicola
    {
        public Nodo IZQ, DER;
        public int tope, limite;


        public Bicola()
        {
            IZQ = DER = null;
            tope = 0;
            limite = 10;
        }


        public Bicola(int limite)
        {
            IZQ = DER = null;
            tope = 0;
            this.limite = limite;
        }

        public bool Vacia()
        {
            return tope == 0;
        }

        public bool Lleno()
        {
            return tope == limite;
        }

        public void AgregarDI(Autos autos)
        {
            if (!Lleno())
            {
                Nodo aux = new Nodo(autos);

                if (null == DER) IZQ = DER = aux;
                else
                {
                    aux.der = IZQ;
                    IZQ.izq = aux;
                    IZQ = aux;
                }
                tope++;
            }
            else MessageBox.Show("Muchos carros han sido agregados,\n espera la cola porfavor");
        }

        public Autos SalidaDI()
        {
            Autos salida = null;
            if (!Vacia())
            {
                salida = DER.autos;

                if (IZQ==DER) 
                    IZQ = DER = null;
                else
                {
                    DER = DER.izq;
                    DER.der = null;
                }
                tope--;

            }
            else
            {
                MessageBox.Show("Ya puedes agregar nuevos autos");
            }

            return salida;

        }


        public void MostrarDI(DataGridView l)
        {

            l.Rows.Clear();
            Bicola aux = new Bicola(limite);

            while (!Vacia())
            {
                Autos au = SalidaDI();
                l.Rows.Add("AN - "+au.placa,au.marca,au.modelo,au.color);
                aux.AgregarDI(au);
            }                                                           

            for(; !aux.Vacia(); AgregarDI(aux.SalidaDI()));
        }

        public Autos Mayor()
        {
            Autos mayor = null;


            Bicola aux = new Bicola(limite);
            double m = 0;
            while (!Vacia())
            {
                Autos a = SalidaDI();
                if (a.placa >=m)
                {
                    mayor = a;
                    m = a.placa;
                }
                aux.AgregarDI(a);
            }
            for (; !aux.Vacia(); AgregarDI(aux.SalidaDI())) ;
            return mayor;
        }

        public void Ordenamiento()
        {
            int T = tope;

            Bicola temp = new Bicola(limite);
            Bicola aux = new Bicola(limite);

            for (; !aux.Vacia(); temp.AgregarDI(SalidaDI())) ;

            while (tope < T)
            {
                Autos menor = temp.Mayor();
                while (!temp.Vacia())
                {
                    Autos a = temp.SalidaDI();

                    if (a.placa <= menor.placa) menor = a;
                    aux.AgregarDI(a);
                }

                while (!temp.Vacia())
                {
                    Autos a = aux.SalidaDI();
                    if (a.placa == menor.placa) AgregarDI(a);
                    else temp.AgregarDI(a);
                }

            }

        }














    }
}
