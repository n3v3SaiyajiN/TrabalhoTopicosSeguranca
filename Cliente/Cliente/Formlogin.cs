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
            this.SuspendLayout();
            // 
            // Formlogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Formlogin";
            this.Text = "Formlogin";
            this.ResumeLayout(false);

        }
    }
}
