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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }


        private void Clientes_Load(object sender, EventArgs e)
        {

            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllClientes.Select();
        }
        public void atualizaClientes()
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dgvClientes.DataSource = bllClientes.Select();

        }

        private void editarCliente()
        {
            int id = 0;
            string nome = "";
            string endereco = "";
            int numero = 0;
            string cidade = "";
            string email = "";
            string cpf = "";

            id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_cliente"].Value.ToString());
            nome = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            endereco = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            numero = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["numero"].Value.ToString());
            cidade = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
            email = dgvClientes.SelectedRows[0].Cells["email"].Value.ToString();
            cpf = dgvClientes.SelectedRows[0].Cells["cpf"].Value.ToString();

            CadastrarClientes abrir = new CadastrarClientes(this,id, nome, endereco, numero, cidade, email, cpf);
            abrir.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastrarClientes abir = new CadastrarClientes(this,"2");
            abir.Show();
        }


        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            editarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarCliente();
        }
    }

}