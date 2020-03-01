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
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double longitud = Convert.ToDouble(txtLongitud.Text);
            double resultado = 0;
            if (lstLongitudes1.SelectedItem.Equals("Pulgadas"))
            {
                if (lstLongitudes2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud / 12;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Yardas"))
                {
                    resultado = longitud / 36;
                }
                txtResultado.Text = Convert.ToString(resultado);
            }

            else if (lstLongitudes1.SelectedItem.Equals("Pies"))
            {
                if (lstLongitudes2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud * 12;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Yardas"))
                {
                    resultado = longitud / 3;
                }
                txtResultado.Text = Convert.ToString(resultado);
            }
            else if (lstLongitudes1.SelectedItem.Equals("Yardas"))
            {
                if (lstLongitudes2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud / 12;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud * 3;
                }
                else if (lstLongitudes2.SelectedItem.Equals("Yarda"))
                {
                    resultado  = longitud;
                }
                txtResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Seleccione las longitudes que desea convertir");
            }
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
