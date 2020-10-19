using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices;

namespace EmpireVendas.CAMADAS.DAL
{
    public class TipoVenda
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.TipoVenda> Select()
        {
            List<MODEL.TipoVenda> lstTipoVenda = new List<MODEL.TipoVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM tb_tipo_venda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.TipoVenda tipo_venda = new MODEL.TipoVenda();
                    tipo_venda.id_tipo_venda = Convert.ToInt32(dados["id_tipo_venda"].ToString());
                    tipo_venda.desc_tipo_venda = dados["descricao"].ToString();
                    lstTipoVenda.Add(tipo_venda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Tipo de vendas...");
            }
            finally
            {
                conexao.Close();
            }

            return lstTipoVenda;
        }
    }
}
