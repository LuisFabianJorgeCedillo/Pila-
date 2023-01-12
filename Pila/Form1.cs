using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form1 : Form
    {
        public Pila1 p = new Pila1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            string x = textnumero.Text;
            if (p.Llena())
            {
                MessageBox.Show("La pila esta llena");
            }
            else
            {
                p.Insertar(x);
                listBox1.Items.Add(x);
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string x;
            if (p.Vacia())
                MessageBox.Show("Error; la pila de elemento esta vacio");
            else
            {
                x = p.Eliminar();
                listBox1.Items.Remove(x);
            }
        }

        public void apilarpila()
        {

        }
    }
}




