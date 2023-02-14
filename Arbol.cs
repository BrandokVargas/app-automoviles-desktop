using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Automóviles
{
    class Arbol
    {
        public Nodo raiz;

        public Arbol()
        {
            raiz = null;
        }

        public void Insertar(ref Nodo r, Autos autos)
        {
            if (r == null) r = new Nodo(autos);
            else
            {
                if (autos.placa > r.autos.placa)
                    Insertar(ref r.der, autos);
                else
                    if (autos.placa < r.autos.placa)
                    Insertar(ref r.izq, autos);
                else
                    MessageBox.Show("El código de usuario no puede ser repetido");
            }
        }

        public void PreOrden(Nodo r)
        {
            if (r != null)
            {

                PreOrden(r.izq);
                PreOrden(r.der);
            }
        }

        public void PreOrden(Nodo r, DataGridView L)
        {
            if (r != null)
            {
                L.Columns.Add("", "AN - " + r.autos.placa);
                PreOrden(r.izq, L);
                PreOrden(r.der, L);
                

            }
        }
        public void verArbol(Nodo r, Autos[] A, int[] pos, int n, ref int ce)
        {
            if (r != null)
            {
                verArbol(r.izq, A, pos, n + 1, ref ce);
                A[ce] = r.autos;
                pos[ce] = n;
                ce++;
                verArbol(r.der, A, pos, n + 1, ref ce);
            }
        }

        public int Peso(Nodo r)
        {
            if (r != null)
            {
                int Izq = Peso(r.izq);
                int Der = Peso(r.der);
                int contar = Izq + Der + 1;
                return contar;
            }
            return 0;
        }
        public int Altura(Nodo r)
        {
            if (r != null)
            {
                return 1 + Math.Max(Altura(r.izq), Altura(r.der));
            }
            return 0;
        }


        public void UnirBicolaArbol(Nodo r,Bicola bicola)
        {
            if (r!=null)
            {
                UnirBicolaArbol(r.izq,bicola);
                bicola.AgregarDI(new Autos(r.autos.placa,r.autos.marca,r.autos.modelo,r.autos.color));
                UnirBicolaArbol(r.der,bicola);
            }
        }

        public Autos Buscar(Nodo r, int placa)
        {
            if (r == null)
            {
                return null;
            }
            else if (r.autos.placa == placa)
            {
                return r.autos;
            }
            else if (placa < r.autos.placa)
            {
                return Buscar(r.izq, placa);
            }
            else
            {
                return Buscar(r.der, placa);
            }
        }


        public void Invertir(Nodo r,DataGridView L)
        {

            if (r != null)
            {

                //INVERTIR
                Invertir(r.der, L);
                Invertir(r.izq, L);
                L.Columns.Add("", "AN - " + r.autos.placa);


            }

        }
        public void OrdenarDescendemente(Nodo r, DataGridView L)
        {

            if (r != null)
            {

                //ORDENAR
                OrdenarDescendemente(r.izq, L);
                L.Columns.Add("", "AN - " + r.autos.placa);
                OrdenarDescendemente(r.der, L);

                /////////////////////////////////////////
                Invertir(raiz,L);

            }

        }


    }
}
