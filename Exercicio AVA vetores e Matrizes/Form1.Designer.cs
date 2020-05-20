namespace Exercicio_AVA_vetores_e_Matrizes
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
            this.lstVetor = new System.Windows.Forms.ListBox();
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVetor
            // 
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 16;
            this.lstVetor.Location = new System.Drawing.Point(66, 161);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(350, 260);
            this.lstVetor.TabIndex = 0;
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(66, 92);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(350, 35);
            this.btnVetor.TabIndex = 1;
            this.btnVetor.Text = "Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(501, 92);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(332, 35);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.ItemHeight = 16;
            this.lstMatriz.Location = new System.Drawing.Point(501, 161);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(350, 260);
            this.lstMatriz.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 572);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.lstVetor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Matrizes e Vetores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVetor;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
    }
}

