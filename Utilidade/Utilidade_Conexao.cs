using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utilidade
{
   
        public class Utilidade_Conexao
        {

            private string _stringConexao;

            private MySqlConnection _conexao;


            public Utilidade_Conexao(string dadosConexao)
            {
                this._conexao = new MySqlConnection();
                this.StringConexao = dadosConexao;
                this._conexao.ConnectionString = dadosConexao;

            }


            public string StringConexao
            {
                get => this._stringConexao;
                set => this._stringConexao = value;
            }

            public MySqlConnection Conexao
            {
                get => this._conexao;
                set => this._conexao = value;

            }

            public void AbrirConexao()
            {
                this.Conexao.Open();
            }
            public void FecharConexao()
            {
                this.Conexao.Close();
            }
        }
    
}

