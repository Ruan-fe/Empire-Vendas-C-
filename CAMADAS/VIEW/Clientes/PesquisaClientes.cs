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
    public partial class PesquisaClientes : Form
    {
        Recebimentos Instancia;
        public PesquisaClientes(Recebimentos recebimentos)
        {
            InitializeComponent();
            Instancia = recebimentos;
        }

        private void FormasPagamentos_Load(object sender, EventArgs e)
        {

        }
        private void filtrar()
        {
            CAMADAS.BLL.Clientes clientes = new CAMADAS.BLL.Clientes();
            string nome = txtBusca.Text;
            if (txtBusca.Text != "")
            {
                dgvClientes.DataSource = clientes.SelectByNome(nome);
            }
            if (dgvClientes.Rows.Count <= 0 || txtBusca.Text == "")
            {
                MessageBox.Show("Cliente não cadastrado");
                dgvClientes.DataSource = clientes.SelectByNome(nome);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusca.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtCliente.Text = dgvClientes.SelectedRows[0].Cells["id_cliente"].Value.ToString();
        }

        private void dgvClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CAMADAS.BLL.Recebimentos bllRecebimentos = new CAMADAS.BLL.Recebimentos();
            Instancia.setTxtCliente(this.txtCliente.Text);
            Instancia.setTxtBusca(this.txtBusca.Text);
            int id = Convert.ToInt32(txtCliente.Text);
            Instancia.dgvRecebimentos.DataSource = bllRecebimentos.SelectById(id);
            Instancia.atualizarContasPendentes();
            this.Close();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; e.SuppressKeyPress = true; txtBusca.Focus();
                filtrar();
            }
        }
    }
}
