using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using System;
using GestaoFinanceira.Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GestaoFinanceira.Valicadao
{
    public class validacao_Cliente
    {
        private Utilidade_Conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public validacao_Cliente(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarCliente(modelo_Cliente mod_cliente)
        {
            if (mod_cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_cliente.Cli_cpf.Trim().Length == 0)
            {
                MessageBox.Show("O CPF do cliente é obrigatório", "Validação CPF", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.SalvarCliente(mod_cliente);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>

        public void EditarCliente(modelo_Cliente mod_cliente)
        {
            if (mod_cliente.Cli_id <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            
            negocio_Cliente negocio_Cliente = new negocio_Cliente(conexao);
            negocio_Cliente.EditarCliente(mod_cliente);
        }

        /// <summary>
        /// metodo de validacao para classe excluir usuario
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirCliente(int codigo)
        {
            negocio_Cliente negocio_Cliente = new negocio_Cliente(conexao);
            negocio_Cliente.ExcluirCliente(codigo);
        }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 

        public DataTable ListarCliente(String valor)
        {
            negocio_Cliente negocio_Cliente = new negocio_Cliente(conexao);
            return negocio_Cliente.ListarCliente(valor);
        }



        /*public DataTable ListarUsuario()
         {
             negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
             try
             {
                 DataTable dt = new DataTable();
                 dt = negocio_Usuario.ListarUsuario();
                 return dt;
             }
             catch (Exception erro)
             {
                 throw erro;
             }
         }*/

        /// <summary>
        /// metodo de validação de carregar usuarios
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_Cliente CarregarCliente(int codigo)
        {
            negocio_Cliente negocio_Cliente = new negocio_Cliente(conexao);
            return negocio_Cliente.CarregarCliente(codigo);
        }

        public int VerificarCliente(string valor)
        {
            negocio_Cliente negocio_Cliente = new negocio_Cliente(conexao);
            return negocio_Cliente.VerficiarCliente(valor);
        }
    }
}

