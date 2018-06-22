namespace Pagina_Registo
{
    partial class Autenticação
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
            this.lbConfirmpass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPassconfirm = new System.Windows.Forms.TextBox();
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
            // lbConfirmpass
            // 
            this.lbConfirmpass.AutoSize = true;
            this.lbConfirmpass.Location = new System.Drawing.Point(53, 245);
            this.lbConfirmpass.Name = "lbConfirmpass";
            this.lbConfirmpass.Size = new System.Drawing.Size(94, 13);
            this.lbConfirmpass.TabIndex = 2;
            this.lbConfirmpass.Text = "Confirm Password:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(167, 153);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(336, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(167, 199);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(336, 20);
            this.tbPass.TabIndex = 4;
            // 
            // tbPassconfirm
            // 
            this.tbPassconfirm.Location = new System.Drawing.Point(167, 242);
            this.tbPassconfirm.Name = "tbPassconfirm";
            this.tbPassconfirm.Size = new System.Drawing.Size(336, 20);
            this.tbPassconfirm.TabIndex = 5;
            this.tbPassconfirm.TextChanged += new System.EventHandler(this.tbPassconfirm_TextChanged);
            // 
            // Autenticação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 329);
            this.Controls.Add(this.tbPassconfirm);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbConfirmpass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsername);
            this.Name = "Autenticação";
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbConfirmpass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPassconfirm;
    }
}

