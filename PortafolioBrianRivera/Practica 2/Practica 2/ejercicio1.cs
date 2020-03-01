using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtnumero.Text);
                string romano = "";
                if (numero >= 1 && numero <= 10)
                {
                    if (numero == 1)
                    {
                        romano = "I";
                    }
                    else if (numero == 2)
                    {
                        romano = "II";
                    }
                    else if (numero == 3)
                    {
                        romano = "III";
                    }
                    else if (numero == 4)
                    {
                        romano = "IV";
                    }
                    else if (numero == 5)
                    {
                        romano = "VI";
                    }
                    else if (numero == 7)
                    {
                        romano = "VII";
                    }
                    else if (numero == 8)
                    {
                        romano = "VII";
                    }
                    else if (numero == 9)
                    {
                        romano = "IX";
                    }
                    else if (numero == 10)
                    {
                        romano = "X";
                    }

                    lblRomano.Text = "Equivalente a " + romano + " en romano ";
                 
                }
                else
                {
                    txtnumero.Focus();
                    txtnumero.SelectAll();
                    lblRomano.Text = "Ingrese un numero entre el 1 y 10";
                }
             
            }
                catch (Exception)
            {
                txtnumero.Focus();
                txtnumero.SelectAll();
                lblRomano.Text = "Error, solo numeros...";
            }
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
