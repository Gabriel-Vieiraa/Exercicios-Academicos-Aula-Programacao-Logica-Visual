namespace Exercicio_Projeto_Somatorio_dos_N_Pares
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMultiplo = new System.Windows.Forms.TextBox();
            this.lblMultiplo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 24);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 17);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numero";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(26, 166);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(44, 17);
            this.lblSoma.TabIndex = 1;
            this.lblSoma.Text = "Soma";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(97, 24);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(252, 22);
            this.txtNum.TabIndex = 2;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(97, 166);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(252, 22);
            this.txtSoma.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(122, 111);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(237, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMultiplo
            // 
            this.txtMultiplo.Location = new System.Drawing.Point(97, 70);
            this.txtMultiplo.Name = "txtMultiplo";
            this.txtMultiplo.Size = new System.Drawing.Size(252, 22);
            this.txtMultiplo.TabIndex = 6;
            // 
            // lblMultiplo
            // 
            this.lblMultiplo.AutoSize = true;
            this.lblMultiplo.Location = new System.Drawing.Point(14, 70);
            this.lblMultiplo.Name = "lblMultiplo";
            this.lblMultiplo.Size = new System.Drawing.Size(56, 17);
            this.lblMultiplo.TabIndex = 7;
            this.lblMultiplo.Text = "Multiplo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 259);
            this.Controls.Add(this.lblMultiplo);
            this.Controls.Add(this.txtMultiplo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Soma dos Pares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMultiplo;
        private System.Windows.Forms.Label lblMultiplo;
    }
}

