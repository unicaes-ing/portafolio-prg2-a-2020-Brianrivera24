﻿using System;
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
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, prom;
            c1 = Convert.ToDouble(txtExamen1.Text);
            c2 = Convert.ToDouble(txtExamen2.Text);
            c3 = Convert.ToDouble(txtExamen3.Text);
            prom = (c1 + c2 + c3) / 3.0;

            txtPromedio.Text = prom.ToString("N2");


        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtExamen1.Clear();
            txtExamen2.Clear();
            txtExamen3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtExamen1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

