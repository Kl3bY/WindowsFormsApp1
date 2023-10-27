﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 + n2;
            lblResultado.Text = resultado.ToString("F2");

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 - n2;
            lblResultado.Text = resultado.ToString("F2");

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 * n2;
            lblResultado.Text = resultado.ToString("F2");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 / n2;
            lblResultado.Text = resultado.ToString("F2");
        }
    }
}
