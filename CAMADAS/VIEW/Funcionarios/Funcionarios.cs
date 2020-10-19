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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }



        private void Funcionarios_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Funcionarios bllFuncionario = new CAMADAS.BLL.Funcionarios();
            dgvFuncionarios.DataSource = "";
            dgvFuncionarios.DataSource = bllFuncionario.Select();
        }


        private void dgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            cadastrarFuncionario();
        }

        private void cadastrarFuncionario()
        {
            int id = 0;
            string nome = "";
            string endereco = "";
            int numero = 0;
            string cidade = "";
            string email = "";

            id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["id_vendedor"].Value.ToString());
            //txtUsuario.Text = dgvFuncionarios.SelectedRows[0].Cells["usuario"].Value.ToString();
            //txtSenha.Text = dgvFuncionarios.SelectedRows[0].Cells["senha"].Value.ToString();
            nome = dgvFuncionarios.SelectedRows[0].Cells["nome"].Value.ToString();
            endereco = dgvFuncionarios.SelectedRows[0].Cells["endereco"].Value.ToString();
            numero =Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["numero"].Value.ToString());
            cidade = dgvFuncionarios.SelectedRows[0].Cells["cidade"].Value.ToString();
            email = dgvFuncionarios.SelectedRows[0].Cells["email"].Value.ToString();


            CadastrarFuncionarios abrir = new CadastrarFuncionarios(this, id, nome, endereco, numero, cidade, email);
            abrir.Show();
        }
        private void novoFuncionario()
        {
            CadastrarFuncionarios abrir = new CadastrarFuncionarios();
            abrir.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novoFuncionario();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            cadastrarFuncionario();
        }

    }
}
