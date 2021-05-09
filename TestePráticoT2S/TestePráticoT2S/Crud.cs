using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TestePráticoT2S
{
    public class Crud
    {
        MySqlCommand comando;
        MySqlConnection conexao;
        MySqlDataReader leitor;

        public Crud()
        {
            conexao = new MySqlConnection("Server=localhost;Database=bd_testet2s;Uid=root;Pwd=1234;");
        }

        #region CUD(criate,update,delete)
        public String OperacaoBanco(String sql)
        {
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                return "<br /><h3>Operação realizada com sucesso!</h3>";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally{ conexao.Close(); }
        }
        #endregion
        #region R(Read)
        public DataTable PesquisarContainer(String sql)
        {
            DataTable valores = new DataTable();
            valores.Columns.Add("ID",typeof(String));
            valores.Columns.Add("Cliente", typeof(String));
            valores.Columns.Add("Container", typeof(String));
            valores.Columns.Add("Tipo", typeof(String));
            valores.Columns.Add("Status", typeof(String));
            valores.Columns.Add("Categoria", typeof(String));
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    valores.Rows.Add(leitor["cd_container"].ToString(),leitor["nm_cliente_container"].ToString(), leitor["nm_controle_container"].ToString(), leitor["nm_tipo_container"].ToString(), leitor["nm_status_container"].ToString(), leitor["nm_categoria_container"].ToString() == "I" ? "Importação" : "Exportação");
                }
                conexao.Close();
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexao.Close(); }
        }
        public DataTable PesquisarMovimentacao(String sql)
        {
            DataTable valores = new DataTable();
            valores.Columns.Add("ID", typeof(String));
            valores.Columns.Add("Navio", typeof(String));
            valores.Columns.Add("Movimentação", typeof(String));
            valores.Columns.Add("Início", typeof(String));
            valores.Columns.Add("Fim", typeof(String));
            valores.Columns.Add("Container", typeof(String));
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    valores.Rows.Add(leitor["cd_movimentacao"].ToString(), leitor["nm_navio_movimentacao"].ToString(), leitor["nm_tipo_movimentacao"].ToString(), leitor["nm_inicio_movimentacao"].ToString(), leitor["nm_fim_movimentacao"].ToString(), leitor["nm_controle_container"].ToString());

                }
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexao.Close(); }
        }
        #endregion
        #region Listar Relatorio
        public DataTable ListarRelatorio(String sql)
        {
            DataTable valores = new DataTable();
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                leitor = comando.ExecuteReader();
                valores.Columns.Add("ID", typeof(String));
                valores.Columns.Add("Cliente", typeof(String));
                valores.Columns.Add("Container", typeof(String));
                valores.Columns.Add("Navio", typeof(String));
                valores.Columns.Add("Categoria", typeof(String));
                valores.Columns.Add("Tipo", typeof(String));
                while (leitor.Read())
                    {

                    valores.Rows.Add(leitor["cd_movimentacao"].ToString(),leitor["nm_cliente_container"].ToString(),leitor["nm_controle_container"].ToString(),leitor["nm_navio_movimentacao"].ToString(),leitor["nm_categoria_container"].ToString() == "I" ? "Importação" : "Exportação",leitor["nm_tipo_movimentacao"].ToString());
                    }
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexao.Close(); }

        }
        #endregion

        }
}