using System;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace GestaoFinanceira.Negocio
{
    public class negocio_Usuario
    {
        public Utilidade_Conexao conexao;
        MySqlCommand comando = null;


        public negocio_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarUsuario(modelo_Usuario mod_usuario)
        {
            try
            {
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO usuario (user_usuario,user_password) VALUES ( @user_usuario, @user_password) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("user_usuario", mod_usuario.User_usuario);
                cmd.Parameters.AddWithValue("user_password", mod_usuario.User_password);
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

        public void EditarUsuario(modelo_Usuario mod_usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE usuario SET user_usuario = @user_usuario, user_password =@user_password WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_usuario", mod_usuario.User_usuario);
                cmd.Parameters.AddWithValue("@user_Password", mod_usuario.User_password);
                cmd.Parameters.AddWithValue("@user_id", mod_usuario.User_id);
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

        public void ExcluirUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM usuario WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_id", codigo);
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
        public DataTable ListarUsuario(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usuario WHERE user_usuario like '%" + valor + "%'" , conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public modelo_Usuario CarregarUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario usuario = new modelo_Usuario();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM usuario WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("@user_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    usuario.User_id = Convert.ToInt32(registro["user_id"]);
                    usuario.User_usuario = Convert.ToString(registro["user_usuario"]);
                    usuario.User_password = Convert.ToString(registro["user_password"]);
                }
                return usuario;
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

       public int VerficiarUsuario(string valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM usuario WHERE user_usuario = @user_usuario;";
                comando.Parameters.AddWithValue("@user_Usuario", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["user_id"]);
                }
                return r;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}
