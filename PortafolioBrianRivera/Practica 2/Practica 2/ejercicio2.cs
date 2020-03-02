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
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double total, descuento, subtotal;
            if (rdoDes0.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.00;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDes5.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.05;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDes10.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.10;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDes15.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.15;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                label4.Text = total.ToString();
            }
            else if (rdoDes20.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.20;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

