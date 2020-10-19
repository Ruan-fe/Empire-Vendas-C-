using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpireVendas
{
    public partial class CadastrarFuncionarios : Form
    {
        Funcionarios instanciarFuncionario;
        public CadastrarFuncionarios()
        {
            InitializeComponent();
            limparControles();
        }

        public CadastrarFuncionarios(Funcionarios funcionarios, int id, string nome, string endereco, int numero, string cidade, string email)
        {
            InitializeComponent();
            instanciarFuncionario = funcionarios;

            txtID.Text = id.ToString();
            txtNome.Text = nome.ToString();
            txtEndereco.Text = endereco.ToString();
            txtNumero.Text = numero.ToString();
            txtCidade.Text = cidade.ToString();
            txtEmail.Text = email.ToString();
        }

        private void CadastrarFuncionarios_Load(object sender, EventArgs e)
        {
            txtNome.Focus();

            if(txtID.Text == "-1")
            {
                btnEditar.Visible = false;
                btnRemover.Visible = false;
                btnGravar.Visible = true;
            }
            else
            {
                btnEditar.Visible = true;
                btnRemover.Visible = true;
                btnGravar.Visible = false;
            }
        }


        private void limparControles()
        {
            txtID.Text = "-1";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";

        }


        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text != "-1" && txtNome.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtCidade.Text != "" && txtEmail.Text != "")
            {
                CAMADAS.MODEL.Funcionarios funcionario = new CAMADAS.MODEL.Funcionarios();
                CAMADAS.BLL.Funcionarios bllFuncionario = new CAMADAS.BLL.Funcionarios();

                funcionario.id_vendedor = Convert.ToInt32(txtID.Text);
                funcionario.nome_vendedor = txtNome.Text;
                funcionario.endereco = txtEndereco.Text;
                funcionario.numero = Convert.ToInt32(txtNumero.Text);
                funcionario.cidade = txtCidade.Text;
                funcionario.email = txtEmail.Text;
                //funcionario.usuario = txtUsuario.Text;
                //funcionario.senha = txtSenha.Text;


                bllFuncionario.Update(funcionario);

                limparControles();
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos.");
            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Funcionarios funcionario = new CAMADAS.MODEL.Funcionarios();
            CAMADAS.BLL.Funcionarios bllFuncionarios = new CAMADAS.BLL.Funcionarios();
            if (txtID.Text == "-1" && txtNome.Text != "" && txtEndereco.Text !=
            "" && txtNumero.Text != "" && txtCidade.Text != "" && txtEmail.Text != "")
            {
                //funcionario.usuario = txtUsuario.Text;
                //funcionario.senha = txtSenha.Text;
                funcionario.nome_vendedor = txtNome.Text;
                funcionario.endereco = txtEndereco.Text;
                funcionario.numero = Convert.ToInt32(txtNumero.Text);
                funcionario.cidade = txtCidade.Text;
                funcionario.email = txtEmail.Text;


                bllFuncionarios.Insert(funcionario);
                limparControles();

            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos.");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            int idFun = Convert.ToInt32(txtID.Text);
            CAMADAS.BLL.Funcionarios bllFun = new CAMADAS.BLL.Funcionarios();
            string msg = "Deseja remover o funcionário selecionado ?";
            DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
                bllFun.Delete(idFun);

            limparControles();

        }
    }
}
