using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numerotabla;
            if (int.TryParse(txtNumero.Text, out numerotabla))
            {
                lstTabla.Items.Clear();
                for (int i =1 ; i < 10; i++)
                {
                    lstTabla.Items.Add(numerotabla + "*" + i + "=" + numerotabla * i);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero");

            }
        }
    }
}
