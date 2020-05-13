using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Projeto_Somatorio_dos_N_Pares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Criando variaveis que receberão o primeiro numero digitado e a soma

            int num, soma = 0;

            //captando o número digitado e jogado na variavel num

            num = Convert.ToInt32(txtNum.Text);

            
            for (int i = 1; i <= num; i++)
            {
                
                if (i%2==0)
                {
                    //somando o que está na variavel soma com o valor de i
                    soma = soma + i;

                   Console.WriteLine("Numero: " +i +" .Soma:" + soma);
                }
            }
            //jogando o total da soma no txt
            txtSoma.Text = soma.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
