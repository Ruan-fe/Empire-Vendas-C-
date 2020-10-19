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
    public class Recebimentos
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Recebimentos> Select(string nome)
        {
            List<MODEL.Recebimentos> lstRecebimentos = new List<MODEL.Recebimentos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT c.nome,r.id_venda,sr.desc_status_recebimento,r.data_compra,r.data_vencimento, v.valor_final " +
                          "FROM tb_recebimentos r " +
                          "INNER JOIN tb_clientes c on c.id_cliente = r.id_cliente " +
                          "INNER JOIN tb_status_recebimento sr on sr.id_status_recebimento = r.id_status_recebimento " +
                          "INNER JOIN tb_vendas v on v.id_venda = r.id_venda " +
                          "WHERE (c.nome LIKE @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Recebimentos recebimento = new MODEL.Recebimentos();
                    recebimento.desc_cliente = dados["nome"].ToString();
                    recebimento.desc_status_recebimento = dados["desc_status_recebimento"].ToString();
                    recebimento.id_venda = Convert.ToInt32(dados["id_venda"].ToString());
                    recebimento.data_compra = Convert.ToDateTime(dados["data_compra"].ToString());
                    recebimento.data_vencimento = Convert.ToDateTime(dados["data_vencimento"].ToString());
                    recebimento.valor = Convert.ToSingle(dados["valor_final"].ToString());
                    lstRecebimentos.Add(recebimento);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Recebimentos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstRecebimentos;
        }
        public List<MODEL.Recebimentos> SelectById(int id)
        {
            List<MODEL.Recebimentos> lstRecebimentos = new List<MODEL.Recebimentos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT c.nome,r.id_venda,sr.desc_status_recebimento,r.data_compra,r.data_vencimento, v.valor_final " +
                          "FROM tb_recebimentos r " +
                          "INNER JOIN tb_clientes c on c.id_cliente = r.id_cliente " +
                          "INNER JOIN tb_status_recebimento sr on sr.id_status_recebimento = r.id_status_recebimento " +
                          "INNER JOIN tb_vendas v on v.id_venda = r.id_venda " +
                          "WHERE c.id_cliente = @id AND sr.id_status_recebimento = 1;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id",id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Recebimentos recebimento = new MODEL.Recebimentos();
                    recebimento.desc_cliente = dados["nome"].ToString();
                    recebimento.desc_status_recebimento = dados["desc_status_recebimento"].ToString();
                    recebimento.id_venda = Convert.ToInt32(dados["id_venda"].ToString());
                    recebimento.data_compra = Convert.ToDateTime(dados["data_compra"].ToString());
                    recebimento.data_vencimento = Convert.ToDateTime(dados["data_vencimento"].ToString());
                    recebimento.valor = Convert.ToSingle(dados["valor_final"].ToString());
                    lstRecebimentos.Add(recebimento);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Recebimentos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstRecebimentos;
        }

    }
}
