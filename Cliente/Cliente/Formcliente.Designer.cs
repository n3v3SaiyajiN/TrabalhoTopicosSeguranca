namespace Cliente
{
    partial class Cliente
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
            this.lbEnviarmensagem = new System.Windows.Forms.Label();
            this.tbEnviarmensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEnviarficheiro = new System.Windows.Forms.Button();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbEnviarmensagem
            // 
            this.lbEnviarmensagem.AutoSize = true;
            this.lbEnviarmensagem.Location = new System.Drawing.Point(53, 52);
            this.lbEnviarmensagem.Name = "lbEnviarmensagem";
            this.lbEnviarmensagem.Size = new System.Drawing.Size(95, 13);
            this.lbEnviarmensagem.TabIndex = 0;
            this.lbEnviarmensagem.Text = "Enviar Mensagem:";
            // 
            // tbEnviarmensagem
            // 
            this.tbEnviarmensagem.Location = new System.Drawing.Point(114, 68);
            this.tbEnviarmensagem.Multiline = true;
            this.tbEnviarmensagem.Name = "tbEnviarmensagem";
            this.tbEnviarmensagem.Size = new System.Drawing.Size(395, 208);
            this.tbEnviarmensagem.TabIndex = 1;
            this.tbEnviarmensagem.TextChanged += new System.EventHandler(this.tbEnviarmensagem_TextChanged);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(515, 253);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(111, 23);
            this.btnEnviarMensagem.TabIndex = 2;
            this.btnEnviarMensagem.Text = "Enviar Mensagem";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(515, 68);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEnviarficheiro
            // 
            this.btnEnviarficheiro.Location = new System.Drawing.Point(515, 224);
            this.btnEnviarficheiro.Name = "btnEnviarficheiro";
            this.btnEnviarficheiro.Size = new System.Drawing.Size(111, 23);
            this.btnEnviarficheiro.TabIndex = 4;
            this.btnEnviarficheiro.Text = "Enviar Ficheiro";
            this.btnEnviarficheiro.UseVisualStyleBackColor = true;
            this.btnEnviarficheiro.Click += new System.EventHandler(this.btnEnviarficheiro_Click);
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OFD1";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 325);
            this.Controls.Add(this.btnEnviarficheiro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.tbEnviarmensagem);
            this.Controls.Add(this.lbEnviarmensagem);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnviarmensagem;
        private System.Windows.Forms.TextBox tbEnviarmensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEnviarficheiro;
        private System.Windows.Forms.OpenFileDialog OFD1;
    }
}

