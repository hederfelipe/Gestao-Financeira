using System;
using System.Data;
using System.Windows.Forms;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using MySql.Data.MySqlClient;

namespace GestaoFinanceira.Negocio
{
    public class negocio_FormaPagamento
    {

        public Utilidade_Conexao conexao;
        MySqlCommand comando = null;


        public negocio_FormaPagamento(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarFormaPagamento(modelo_FormaPagamento mod_formaPagamento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO formapagamento (forma_descricao) VALUES (@descricao) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("descricao", mod_formaPagamento.Forma_descricao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", " Gravar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void EditarFormaPagamento(modelo_FormaPagamento mod_formapagamento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE formapagamento SET forma_descricao = @descricao  WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@descricao", mod_formapagamento.Forma_descricao);
                cmd.Parameters.AddWithValue("@forma_id", mod_formapagamento.Forma_id);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void ExcluirFormaPagamento(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM formapagamento WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        /// <summary>
        /// metodo para preencher data grid view do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable ListarFormaPagamento(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM formapagamento WHERE  forma_descricao like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public modelo_FormaPagamento CarregarFormaPagamento(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagamento formapagamento = new modelo_FormaPagamento();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM formapagamento WHERE forma_id = @forma_id;";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    formapagamento.Forma_id = Convert.ToInt32(registro["forma_id"]);
                    formapagamento.Forma_descricao = Convert.ToString(registro["forma_descricao"]);

                }
                return formapagamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public int VerficiarformaPagamento(string valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM formapagamento WHERE forma_descricao = @forma_descricao;";
                comando.Parameters.AddWithValue("@forma_descricao", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["forma_id"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}




