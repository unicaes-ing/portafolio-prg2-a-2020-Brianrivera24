using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtBinario.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text),2);
            txtOctal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 8);
            txtHexa.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 16);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBinario.Clear();
            txtOctal.Clear();
            txtHexa.Clear();
            txtDecimal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
