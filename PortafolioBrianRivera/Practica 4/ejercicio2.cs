using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        public static int buscar(int numeroBuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int n in lista.Items)
            {
                if (n == numeroBuscar) cont++;
            }
            return cont;
        }
 



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                lstLista.Items.Add(numero);
                txtNumero.Clear();
                txtNumero.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero");
                txtNumero.SelectAll();
                txtNumero.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumBuscar.Text);
                int cant = buscar(num, lstLista);
                MessageBox.Show("Se encuentra " + cant + " veces");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo números");
                txtNumBuscar.SelectAll();
                txtNumBuscar.Focus();
            }
        }
    }
}
