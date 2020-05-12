using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNumeros.Items.Clear();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //usando laço for para preencher o listBox
            lblNumeros.Items.Clear();
            for (int i = 0; i <= 100; i++)
                
                if (i % 2 == 0)
                {
                    lblNumeros.Items.Add(item: i.ToString());
                }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lblNumeros.Items.Clear();
            //Criando variavel contadora
            int i = 0;

            //verificar a repetição
            while (i<=100)
            {
                //verificar se o i é par
                if (i % 2 == 0)
                {
                    lblNumeros.Items.Add(item: i.ToString());
                }
                //Incrementando a variavel de controle
                i++;

            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            lblNumeros.Items.Clear();

            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    lblNumeros.Items.Add(item: i.ToString());
                }
                i++;

            } while (i <= 100);
            
        }
    }
}
