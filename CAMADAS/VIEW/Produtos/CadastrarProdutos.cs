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
    public partial class CadastrarProdutos : Form
    {
        Produtos instanciaProdutos;
        public CadastrarProdutos(Produtos produtos)
        {
            InitializeComponent();
            txtId.Text = "-1";
            instanciaProdutos = produtos;
            CAMADAS.BLL.Categorias dalCat = new CAMADAS.BLL.Categorias();
            cmbCategoria.DataSource = dalCat.Select();
            cmbCategoria.ValueMember = "id_categoria";
            cmbCategoria.DisplayMember = "desc_categoria";
            limparControles();
        }
        public CadastrarProdutos(int id, string produto, float valor, int estoque, string Categoria, int idCategoria)
        {

            InitializeComponent();
            CAMADAS.BLL.Categorias dalCat = new CAMADAS.BLL.Categorias();
            cmbCategoria.DataSource = dalCat.Select();
            cmbCategoria.ValueMember = "id_categoria";
            cmbCategoria.DisplayMember = "desc_categoria";
            txtId.Text = id.ToString();
            txtProduto.Text = produto;
            txtValor.Text = valor.ToString();
            txtEstoque.Text = estoque.ToString();
            cmbCategoria.Text = Categoria.ToString();
            txtIdCategoria.Text = idCategoria.ToString();

            
        }

        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {

            txtProduto.Focus();
            if(txtId.Text == "-1")
            {
                btnEditar.Visible = false;
                btnGravar.Visible = true;
                btnRemover.Visible = false;
            }
            else
            {
                btnEditar.Visible = true;
                btnGravar.Visible = false;
                btnRemover.Visible = true;
            }
        }

        private void limparControles()
        {
            txtId.Text = "-1";
            txtProduto.Text = "";
            txtEstoque.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtIdCategoria.Text = null;
            txtProduto.Focus();
            cmbCategoria.Text = "";

        }

        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Produtos produto = new CAMADAS.MODEL.Produtos();
            CAMADAS.BLL.Produtos bllProduto = new CAMADAS.BLL.Produtos();

            if (txtValor.Text != "" && txtProduto.Text != "" && txtEstoque.Text != "")
            {
                produto.desc_produto = txtProduto.Text;
                produto.valor = Convert.ToSingle(txtValor.Text);
                produto.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                produto.estoque = Convert.ToInt32(txtEstoque.Text);
                bllProduto.Insert(produto);
                /*dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = bllProduto.Select();*/
                limparControles();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            instanciaProdutos.pictureBox2_Click(sender, e);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(txtId.Text);
            CAMADAS.BLL.Produtos bllProd = new CAMADAS.BLL.Produtos();
            string msg = "Deseja remover o produto selecionado ?";
            DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
                bllProd.Delete(idProd);

            /*dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();
            limparControles();*/
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCategoria.Text = cmbCategoria.SelectedValue.ToString();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "-1" && txtValor.Text != "" && txtProduto.Text != "" && txtEstoque.Text != "")
            {
                CAMADAS.BLL.Produtos bllProduto = new CAMADAS.BLL.Produtos();
                CAMADAS.MODEL.Produtos produto = new CAMADAS.MODEL.Produtos();
                produto.id_produto = Convert.ToInt32(txtId.Text);
                produto.desc_produto = txtProduto.Text;
                produto.valor = Convert.ToSingle(txtValor.Text);
                produto.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                produto.estoque = Convert.ToInt32(txtEstoque.Text);
                bllProduto.Update(produto);
                /*dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = bllProduto.Select();*/
                limparControles();
            }
            else
            {
                MessageBox.Show("Não é possível deixar nenhum campo em branco!");
            }
            //instanciaProdutos.pictureBox2_Click(sender, e);
        }
    }
}
