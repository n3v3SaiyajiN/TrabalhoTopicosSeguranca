using Cliente;
using Pagina_Registo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagina_Login
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        public void lbautenticacao_Click(object sender, EventArgs e)
        {
            Form interligar = new Form();
            interligar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbregistro = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(173, 146);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(371, 20);
            this.tbusername.TabIndex = 0;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(173, 183);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(371, 20);
            this.tbpassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(82, 149);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(58, 13);
            this.lbusername.TabIndex = 4;
            this.lbusername.Text = "Username:";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(540, 313);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(101, 33);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // lbregistro
            // 
            this.lbregistro.AutoSize = true;
            this.lbregistro.Location = new System.Drawing.Point(345, 217);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(199, 13);
            this.lbregistro.TabIndex = 6;
            this.lbregistro.Text = "Ainda não está autenticado? Clique Aqui";
            this.lbregistro.Click += new System.EventHandler(this.lbregistro_Click);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(82, 190);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(56, 13);
            this.lbpassword.TabIndex = 7;
            this.lbpassword.Text = "Password:";
            // 
            // Formlogin
            // 
            this.ClientSize = new System.Drawing.Size(653, 358);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbregistro);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbregistro_Click(object sender, EventArgs e)
        {
            Formautenticacao interligar = new Formautenticacao();
            interligar.ShowDialog();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Formcliente interligar = new Formcliente();
            interligar.ShowDialog();
        }
    }
}
