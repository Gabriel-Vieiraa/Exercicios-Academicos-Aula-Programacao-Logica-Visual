using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_AVA_vetores_e_Matrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            // declarando um vetor de 10 posições
        int[] vetor = new int[10];

            int i;    //variável i para o índice

            lstVetor.Items.Clear();

            for (i = 0; i < 10; i++)
            {
                //atribuindo o valor de i para o vetor no índice i
                vetor[i] = i;

                lstVetor.Items.Add("Vetor indice [" + i + "] = " + vetor[i]);
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();

            //variáveis para acessar as posições dos índices da matriz
            // linha - representa linha
            // coluna - representa coluna

            int linha, coluna;

            //declara a variável numeros com 5 linhas e 4 colunas

            int[,] numeros = new int[5, 4];    //dimensão da matriz 5 x 4

            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    numeros[linha, coluna] = linha * coluna;  //atribui o valor de linha * coluna
                }
            }

            //exibindo os dados no ListBox

            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    lstMatriz.Items.Add(item:"elemento - " +""+
                        "["+ linha + ", " + coluna + "] é " +
                        numeros[linha, coluna]);
                }
            }

        }
    }
}
