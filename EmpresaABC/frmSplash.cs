using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaABC
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void pctSplash_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Maximum < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 1;
                lblValor.Text = pgbSplash.Value.ToString();
            } else{
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
                tmrSplash.Enabled = false;
            }

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
