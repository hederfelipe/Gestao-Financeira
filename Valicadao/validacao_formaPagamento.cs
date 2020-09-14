using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using System;
using GestaoFinanceira.Negocio;
using System.Windows.Forms;
using System.Data;

namespace GestaoFinanceira.Valicadao
{
    public class validacao_FormaPagamento
    {
        private Utilidade_Conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public validacao_FormaPagamento(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarFormaPagamento(modelo_FormaPagamento modelo_FormaPagamento)
        {
            if (modelo_FormaPagamento.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da descrição é obrigatório", "Validação Forma de pagamento", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

            negocio_FormaPagamento forma_pagamento = new negocio_FormaPagamento(conexao);
            forma_pagamento.SalvarFormaPagamento(modelo_FormaPagamento);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>

        public void EditarFormaPagamento(modelo_FormaPagamento modelo_formapagamento)
        {
            if (modelo_formapagamento.Forma_id <= 0)
            {
                MessageBox.Show("O código forma de pagamento é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (modelo_formapagamento.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da descição é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

            negocio_FormaPagamento negocio_formapagamento = new negocio_FormaPagamento(conexao);
            negocio_formapagamento.EditarFormaPagamento(modelo_formapagamento);
        }


        /// <summary>
        /// metodo de validacao para classe excluir pagamento
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// 
        public void ExcluirFormaPagamentno(int codigo)
        {
            negocio_FormaPagamento negocio_formapagamento = new negocio_FormaPagamento(conexao);
            negocio_formapagamento.ExcluirFormaPagamento(codigo);
        }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 

        public DataTable ListarFormaPagamento(String valor)
        {
            negocio_FormaPagamento negocio_formapagamento = new negocio_FormaPagamento(conexao);
            return negocio_formapagamento.ListarFormaPagamento(valor);
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
        public modelo_FormaPagamento CarregarFormaPagamento(int codigo)
        {
            negocio_FormaPagamento negocio_Pagamento = new negocio_FormaPagamento(conexao);
            return negocio_Pagamento.CarregarFormaPagamento(codigo);
        }

        public int varificarFromaPagamento(string valor)
        {
            negocio_FormaPagamento negocio_pagamento = new negocio_FormaPagamento(conexao);
            return negocio_pagamento.VerficiarformaPagamento(valor);
        }
    }
}

