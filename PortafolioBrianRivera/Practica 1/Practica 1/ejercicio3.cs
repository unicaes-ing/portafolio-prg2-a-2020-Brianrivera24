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
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double porce1, porce2, porce3, total;
            total = Convert.ToDouble(txtInver1.Text) + Convert.ToDouble(txtInver2.Text) + Convert.ToDouble(txtInver3.Text);
            txtTotal.Text = Convert.ToString(total);
            porce1 = (Convert.ToDouble(txtInver1.Text) / total) * 100;
            txtPorcen1.Text = Convert.ToString(porce1);
            porce2 = (Convert.ToDouble(txtInver2.Text) / total) * 100;
            txtPorcen2.Text = Convert.ToString(porce2);
            porce3 = (Convert.ToDouble(txtInver3.Text) / total) * 100;
            txtPorcen3.Text = Convert.ToString(porce3);




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInver1.Clear();
            txtInver2.Clear();
            txtInver3.Clear();
            txtPorcen1.Clear();
            txtPorcen2.Clear();
            txtPorcen3.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
