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
    public partial class Recebimentos : Form
    {
        public Recebimentos()
        {
            InitializeComponent();
        }

        private void Recebimentos_Load(object sender, EventArgs e)
        {

        }

        public void setTxtCliente(string id)
        {
            txtCliente.Text = id;
        }

        public void setTxtBusca(string nome)
        {
            txtBusca.Text = nome;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Recebimentos bllRecebimentos = new CAMADAS.BLL.Recebimentos();
            PesquisaClientes abrir = new PesquisaClientes(this);
            abrir.Show();
            //string nome = txtBusca.Text;
            //dgvRecebimentos.DataSource = bllRecebimentos.SelectById(2);

        }

        public void atualizarContasPendentes()
        {
            float valorTotal = 0;
            for (Int32 i = 0; i < dgvRecebimentos.Rows.Count; i++)
            {
                valorTotal += Convert.ToSingle(dgvRecebimentos.Rows[i].Cells[4].Value.ToString());// coluna 5

            }
            lblTotalPendente.Text = valorTotal.ToString();
        }

        public void dgvRecebimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvRecebimentos.Columns[e.ColumnIndex].Name == "desc_status_recebimento")
                if (Convert.ToString(e.Value) == "PENDENTE")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }

        }

        private void dgvRecebimentos_MouseClick(object sender, MouseEventArgs e)
        {

            lblTotalReceber.Text = dgvRecebimentos.SelectedRows[0].Cells["valor"].Value.ToString();
        }
    }
}
