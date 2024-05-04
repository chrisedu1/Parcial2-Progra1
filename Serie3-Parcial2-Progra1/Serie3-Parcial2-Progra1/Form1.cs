using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serie3_Parcial2_Progra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double tasaInteres = double.Parse(txtInteres.Text) / 100;
            int periodo = int.Parse(txtTiempo.Text);

            double capitalFinal = monto * Math.Pow(1 + tasaInteres, periodo);
            double interesesAcumulados = capitalFinal - monto;

            MessageBox.Show("El capital final es: " + capitalFinal + " y los intereses acumulados son: " + interesesAcumulados);

         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
