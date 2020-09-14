using GestaoFinanceira.Utilidade;
using MetroFramework.Forms;
using System.Windows.Forms;
using GestaoFinanceira.Valicadao;
using MetroFramework;
using System;
using GestaoFinanceira.Modelo;

namespace GestaoFinanceira.Visual
{
    public partial class FormPagamento : MetroForm
    {
        /// <summary>
        /// variavel global do formulario
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string  usuario , operacao;

        public FormPagamento()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botão voltar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void AlteraBotao(int op)
        {
            BotonCancelar.Enabled = false;
            BotonNovo.Enabled = false;
            BotonVoltar.Enabled = false;
            BotonGravar.Enabled = false;
            BotonEditar.Enabled = false;
            BotonExcluir.Enabled = false;
            BotonPesquisar.Enabled = false;


            if (op == 1)
            {
                BotonNovo.Enabled = true;
                BotonPesquisar.Enabled = true;
                BotonVoltar.Enabled = true;
            }
            if (op == 2)
            {
                BotonGravar.Enabled = true;
                BotonCancelar.Enabled = true;
            }
            if (op == 3)
            {
                BotonExcluir.Enabled = true;
                BotonEditar.Enabled = true;
                BotonCancelar.Enabled = true;
            }
        }

        /// <summary>
        /// função habilita campos do formulario
        /// </summary>
        public void HabilitaCampos()
        {
            txtPagamento.Enabled = true;
        }

        /// <summary>
        /// função desabilita campos do formulario
        /// </summary>
        public void DesabilitaCampos()
        {
            txtPagamento.Enabled = false;
        }

        /// <summary>
        /// evento loado do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPagamento_Load(object sender, System.EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// função para limpar os campos
        /// </summary>
        public void LimpaCampos()
        {
            txtPagamento.Text = "";
            txtCodigo.Text = "";
        }

        /// <summary>
        /// metodo do botão novo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonNovo_Click(object sender, System.EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtPagamento.Focus();
            this.AlteraBotao(2);
        }

        /// <summary>
        /// metodo botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCancelar_Click(object sender, System.EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotao(1);
            this.txtPagamento.Focus();
        }



        /// <summary>
        /// metodo do botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEditar_Click(object sender, System.EventArgs e)
        {
            this.operacao = "editar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtPagamento.Focus();
        }

        /// <summary>
        /// metodo do botão excluir
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
                "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_FormaPagamento valida_pagamento = new validacao_FormaPagamento(conexao);
                    valida_pagamento.ExcluirFormaPagamentno(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n  Forma de pagamento excluido com sucesso ",
                    "ESCLUSÃO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel excluir usuário do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPagamento.Focus();
                this.AlteraBotao(3);
            }
        }

        private void BotonPesquisar_Click(object sender, EventArgs e)
        {
            FormRelatorioFormaPagamento relatorio = new FormRelatorioFormaPagamento();
            relatorio.ShowDialog();
            if(relatorio.codigo != 0)
            {
                validacao_FormaPagamento valida = new validacao_FormaPagamento(conexao);
                modelo_FormaPagamento modelo_pagamento = valida.CarregarFormaPagamento(relatorio.codigo);
                txtCodigo.Text = modelo_pagamento.Forma_id.ToString();
                txtPagamento.Text = modelo_pagamento.Forma_descricao;
                AlteraBotao(3);
            }
            else { }
            relatorio.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagamento modelo_Pagamento = new modelo_FormaPagamento();
                modelo_Pagamento.Forma_descricao = txtPagamento.Text;
                validacao_FormaPagamento valida_forma = new validacao_FormaPagamento(conexao);
                if (operacao == "cadastrar")
                {

                    valida_forma.SalvarFormaPagamento(modelo_Pagamento);
                    MetroMessageBox.Show(this, "\n\n Forma de pagamento Cadastrado com sucesso ", "CADASTRO DE PAGAMENTO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_Pagamento.Forma_id = Convert.ToInt32(txtCodigo.Text);
                    valida_forma.EditarFormaPagamento(modelo_Pagamento);
                    MetroMessageBox.Show(this, "\n\n   Forma de pagamento editado com sucesso ", "CADASTRO DE PAGAMENTO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao realizar a operação \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }



    }
}


