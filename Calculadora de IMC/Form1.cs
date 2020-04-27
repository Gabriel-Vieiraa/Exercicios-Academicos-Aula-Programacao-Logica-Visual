using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora_de_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double imc, altura, peso;
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            imc = peso / (altura * altura);
            

            decimal x = Convert.ToDecimal(imc.ToString(), new CultureInfo("pt-BR"));
            imc = Convert.ToDouble(x.ToString("N2"));

            if (imc < 18.5)
            {
                MessageBox.Show("Seu IMC é:" + imc, "Você está abaixo do peso", MessageBoxButtons.OK);
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                MessageBox.Show("Seu IMC é:" + imc, "Parabéns! Você está com o peso normal", MessageBoxButtons.OK);
            }
            else if ((imc > 25) && (imc < 30))
            {
                MessageBox.Show("Seu IMC é:" + imc, "Cuidado! Você está acima do peso", MessageBoxButtons.OK);
            }
            else if ((imc > 30) && (imc < 35))
            {
                MessageBox.Show("Seu IMC é:" + imc, " Procure um médico. Você está com obesidade grau 1", MessageBoxButtons.OK);
            }
            else if ((imc > 35) && (imc < 40))
            {
                MessageBox.Show("Seu IMC é:" + imc, "Procure um médico. Você está com obesidade grau 2", MessageBoxButtons.OK);
            }
            else if (imc > 40)
            {
                MessageBox.Show("Seu IMC é:" + imc, "Procure um médico,voce está com obesidade grau 3", MessageBoxButtons.OK);
            }
        }

    }
}
