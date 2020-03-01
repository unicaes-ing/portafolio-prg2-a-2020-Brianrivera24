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
    public partial class ejercicio4 : Form
    {
        public ejercicio4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int cant;
            double sub, impuesto, total;
            if (cboTituloLibro.SelectedItem.Equals("Matematica III"))
            {
                cant = Convert.ToInt32(txtCantidad.Text);
                sub = Convert.ToDouble(txtSubtotal.Text) * cant;
                txtSubtotal.Text = sub.ToString();
                impuesto = (sub * 1.13) - sub;
                total = sub + impuesto;
                txtTotal.Text = total.ToString();

            }
            else if (cboTituloLibro.SelectedItem.Equals("Biblia"))
            {
                cant = Convert.ToInt32(txtCantidad.Text);
                sub = Convert.ToDouble(txtSubtotal.Text) * cant;
                txtSubtotal.Text = sub.ToString();
                impuesto = (sub * 1.13) - sub;
                total = sub + impuesto;
                txtTotal.Text = total.ToString();
            }
            else if (cboTituloLibro.SelectedItem.Equals("Calculo I"))
            {
                cant = Convert.ToInt32(txtCantidad.Text);
                sub = Convert.ToDouble(txtSubtotal.Text) * cant;
                txtSubtotal.Text = sub.ToString();
                impuesto = (sub * 1.13) - sub;
                total = sub + impuesto;
                txtTotal.Text = total.ToString();
            }
            else if (cboTituloLibro.SelectedItem.Equals("Programacion II"))
            {
                cant = Convert.ToInt32(txtCantidad.Text);
                sub = Convert.ToDouble(txtSubtotal.Text) * cant;
                txtSubtotal.Text = sub.ToString();
                impuesto = (sub * 1.13) - sub;
                total = sub + impuesto;
                txtTotal.Text = total.ToString();
            }
            else
            {
                cant = Convert.ToInt32(txtCantidad.Text);
                sub = Convert.ToDouble(txtSubtotal.Text) * cant;
                txtSubtotal.Text = sub.ToString();
                impuesto = (sub * 1.13) - sub;
                total = sub + impuesto;
                txtTotal.Text = total.ToString();
            }


        }

        private void cboTituloLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int libro1,libro2,libro3,libro4,libro5;
            libro1 = 40;
            libro2 = 17;
            libro3 = 49;
            libro4 = 10;
            libro5 = 10;

            if (cboTituloLibro.SelectedItem.Equals("Matematica III")) 
            {
                txtPrecio.Text = libro1.ToString();
                
            }
            else if (cboTituloLibro.SelectedItem.Equals("Biblia"))
            {
                txtPrecio.Text = libro2.ToString();
            }
            else if (cboTituloLibro.SelectedItem.Equals("Calculo I"))
            {
                txtPrecio.Text = libro3.ToString();
            }
            else if (cboTituloLibro.SelectedItem.Equals("programación II"))
            {
                txtPrecio.Text = libro4.ToString();
            }
            else 
            {
                txtPrecio.Text = libro5.ToString();
            }
   
           
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtImpuestos.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
