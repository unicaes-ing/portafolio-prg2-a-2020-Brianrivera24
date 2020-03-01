using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class frmSistemas : Form
    {
        public frmSistemas()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtBinario.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 2);
            txtOctal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 8);
            txtHexa.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 16);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
