namespace Pagina_Login
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbautenticacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbautenticacao
            // 
            this.lbautenticacao.AutoSize = true;
            this.lbautenticacao.Location = new System.Drawing.Point(464, 248);
            this.lbautenticacao.Name = "lbautenticacao";
            this.lbautenticacao.Size = new System.Drawing.Size(118, 13);
            this.lbautenticacao.TabIndex = 0;
            this.lbautenticacao.Text = "Não está autenticado?!";
            this.lbautenticacao.Click += new System.EventHandler(this.lbautenticacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 336);
            this.Controls.Add(this.lbautenticacao);
            this.Name = "Form1";
            this.Text = "Formlogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbautenticacao;
    }
}

