using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmpireVendas
{
    public partial class CadastrarClientes : Form
    {
        Vendas instanciarVendas;
        Clientes instanciarClientes;
        public CadastrarClientes(Vendas venda)
        {
            
            InitializeComponent();
            txtAtt.Text = "1";
            instanciarVendas = venda;
            limparControles();

        }
        public CadastrarClientes()
        {
            InitializeComponent();
            limparControles();
        }
        public CadastrarClientes(Clientes clientes, string number)
        {
            
            InitializeComponent();
            txtAtt.Text = number;
            instanciarClientes = clientes;
            limparControles();
        }

        public CadastrarClientes(Clientes cliente, int id, string nome, string endereco, int numero, string cidade, string email, string cpf)
        {
            InitializeComponent();
            
            txtAtt.Text = "2";
            txtID.Text = id.ToString();
            txtNome.Text = nome.ToString();
            txtEndereco.Text = endereco.ToString();
            txtNumero.Text = numero.ToString();
            txtCidade.Text = cidade.ToString();
            txtEmail.Text = email.ToString();
            txtCPF.Text = cpf.ToString();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {
            txtNome.Focus();

            if (txtID.Text == "-1")
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
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            if (txtID.Text == "-1" && txtNome.Text != "" && txtEndereco.Text !=
                "" && txtNumero.Text != "" && txtCidade.Text != "" && txtEmail.Text != "" && txtCPF.Text != "")
            {

                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.numero = Convert.ToInt32(txtNumero.Text);
                cliente.cidade = txtCidade.Text;
                cliente.email = txtEmail.Text;
                cliente.cpf = txtCPF.Text;
                bllCliente.Insert(cliente);
                //instanciarVendas.pictureBox3_Click(sender, e);
                this.Close();

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            atualizarDgvGrid();
        }

        private void atualizarDgvGrid()
        {
            if (txtAtt.Text == "1")
                instanciarVendas.atualizaClientes();
            else
                instanciarClientes.atualizaClientes();
        }


        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text != "-1" && txtNome.Text != "" && txtEndereco.Text !=
               "" && txtNumero.Text != "" && txtCidade.Text != "" && txtEmail.Text != "" && txtCPF.Text != "")
            {
                CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
                CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();

                cliente.id_cliente = Convert.ToInt32(txtID.Text);
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.numero = Convert.ToInt32(txtNumero.Text);
                cliente.cidade = txtCidade.Text;
                cliente.email = txtEmail.Text;
                cliente.cpf = txtCPF.Text;


                bllCliente.Update(cliente);
                limparControles();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(txtID.Text);
            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            string msg = "Deseja remover o cliente selecionado ?";
            DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
                bllCli.Delete(idCli);

            limparControles();
        }
    }
}
