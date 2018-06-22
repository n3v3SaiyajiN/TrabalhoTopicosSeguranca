namespace Pagina_Registo
{
    partial class Formautenticacao
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(53, 156);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(55, 202);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(56, 13);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(167, 153);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(336, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(167, 199);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(336, 20);
            this.tbPass.TabIndex = 4;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(428, 265);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 5;
            this.btn_iniciar.Text = "Iniciar Sessão";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            // 
            // Formautenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 329);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsername);
            this.Name = "Formautenticacao";
            this.Text = "Formautenticacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btn_iniciar;
    }
}

