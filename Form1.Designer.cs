
namespace Calculadora
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(12, 14);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(271, 20);
            this.textResultado.TabIndex = 0;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Location = new System.Drawing.Point(255, 17);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(24, 13);
            this.labelOperacao.TabIndex = 1;
            this.labelOperacao.Text = "text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 414);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.textResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label labelOperacao;
    }
}

