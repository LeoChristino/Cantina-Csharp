using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;

namespace EmpresaABC
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            // executando método de desabilitar campos
            desabilitasCampos();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //verificando se os campos estão preenchidos
            if (txtNome.Text.Equals("") 
                || txtEmail.Text.Equals("")
                || mskCPF.Text.Equals("   ,   ,   -") 
                || mskCEP.Text.Equals("     -")
                || mskTel.Text.Equals("     -") 
                || txtEnd.Text.Equals("") 
                || txtNun.Text.Equals("") 
                || txtBairro.Text.Equals("") 
                || txtCidade.Text.Equals("") 
                || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Não deixar campos vazios.");

            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!!!");
                desabilitasCampos();
                limparCampos();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //criando método desabilitar campos 
        public void desabilitasCampos()
        {
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtCod.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtNome.Enabled = false;
            txtNun.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTel.Enabled = false;
            cbbEstado.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;  
        }
        //criando método desabilitar campos 
        public void habilitarCampos()
        {
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtNome.Enabled = true;
            txtNun.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTel.Enabled = true;
            cbbEstado.Enabled = true;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;


        }

         //criando método limpar campos 
            public void limparCampos()
            {
                txtBairro.Clear();
                txtCidade.Clear();
                txtCod.Clear();
                txtEmail.Clear();
                txtEnd.Clear();
                txtNome.Clear();
                txtNun.Clear();
                mskCEP.Clear();
                mskCPF.Clear();
                mskTel.Clear();
                cbbEstado.Text = "";
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLimpar.Enabled = false;
                btnNovo.Enabled = true;
            }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Keys(object sender, KeyEventArgs e)
        {

        }
    }
}
