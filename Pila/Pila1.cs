using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public class Pila1
    {
        public string[] piladatos = new string[100];
        public int tope = -1;
        public int MaxPila = 5;
        public string valor = "";

        public Pila1()
        {
            tope = -1;
        }

        public bool Vacia()
        {
            if (tope == -1) return true;
            else return false;
        }

        public bool Llena()
        {
            if (tope == MaxPila - 1) return true;
            else return false;
        }

        public void Insertar(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La pila de elementos esta LLENA");
            else
            {
                tope++;
                piladatos[tope] = insert;
            }
        }

        public string Eliminar()
        {
            string valor = " ";
            if (Vacia()) MessageBox.Show("Error: La pila de elementos esta VACIA");
            else
            {
                valor = piladatos[tope];
                tope--;
            }
            return valor;
        }
    }
}