using EmpireVendas.CAMADAS.DAL;
using EmpireVendas.CAMADAS.MODEL;
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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

            
            CAMADAS.BLL.Produtos bllProdutos = new CAMADAS.BLL.Produtos();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProdutos.Select();
            
        }

        private void abrirCadastroProduto()
        {
            CAMADAS.MODEL.Produtos produtos = new CAMADAS.MODEL.Produtos();
            CadastrarProdutos cadastrar = new CadastrarProdutos(this);
            cadastrar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void filtrar()
        {
            if (txtFiltro.Text != "")
            {
                CAMADAS.BLL.Produtos bllProduto = new CAMADAS.BLL.Produtos();
                List<CAMADAS.MODEL.Produtos> lstProdutos = new List<CAMADAS.MODEL.Produtos>();
                if (checkTodos.Checked)
                    lstProdutos = bllProduto.Select();
                else if (checkNome.Checked)
                    lstProdutos = bllProduto.SelectByNome(txtFiltro.Text);
                else
                {
                    int id = Convert.ToInt32(txtFiltro.Text);
                    lstProdutos = bllProduto.SelectByID(id);

                }

                dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = lstProdutos;
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar();
        }


        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; e.SuppressKeyPress = true; txtFiltro.Focus();
                filtrar();
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && checkId.Checked)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void checkId_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
        }


        public void pictureBox2_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produtos bllProduto = new CAMADAS.BLL.Produtos();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProduto.Select();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirCadastroProduto();
        }

        private void EditarProduto()
        {
            int id = 0;
            string produto = "";
            float valor = 0;
            int estoque = 0;
            string Categoria = "";
            int idCategoria = 0;
            id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["id_produto"].Value.ToString());
            produto = dgvProdutos.SelectedRows[0].Cells["desc_produto"].Value.ToString();
            valor = Convert.ToSingle(dgvProdutos.SelectedRows[0].Cells["valor"].Value.ToString());
            estoque = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["estoque"].Value.ToString());
            Categoria = dgvProdutos.SelectedRows[0].Cells["desc_categoria"].Value.ToString();
            idCategoria = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["idCategoria"].Value.ToString());
            CadastrarProdutos abrir = new CadastrarProdutos(id, produto, valor, estoque, Categoria, idCategoria);
            abrir.Show();
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            {
                if (this.dgvProdutos.Columns[e.ColumnIndex].Name == "estoque")
                    if (Convert.ToInt32(e.Value) <= 0)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Red;
                    }
                if (this.dgvProdutos.Columns[e.ColumnIndex].Name == "estoque")
                    if (Convert.ToInt32(e.Value) > 0 && Convert.ToInt32(e.Value) <= 10)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Orange;
                    }
                if (this.dgvProdutos.Columns[e.ColumnIndex].Name == "estoque")
                    if (Convert.ToInt32(e.Value) > 10)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Green;
                    }
            }
        }

        private void dgvProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            EditarProduto();
        }
    }
}


