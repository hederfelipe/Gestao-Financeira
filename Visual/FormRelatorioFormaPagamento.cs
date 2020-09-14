using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Validacao;
using MetroFramework;
using GestaoFinanceira.Valicadao;

namespace GestaoFinanceira.Visual
{
    public partial class FormRelatorioFormaPagamento : MetroForm
    { 


        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);

        public FormRelatorioFormaPagamento()
        {
            InitializeComponent();
        }


        private void FormRelatorioFormaPagamento_Load(object sender, EventArgs e)
        {
            {
                cmdGerarArquivo.Items.Insert(0, "");
                cmdGerarArquivo.Items.Insert(1, "Gerar PDF");
                cmdGerarArquivo.Items.Insert(2, "Gerar Excel");
                cmdGerarArquivo.Items.Insert(3, "Gerar Word");


                // Mudar cor do Grid
                GridFormaPagamento.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                GridFormaPagamento.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                GridFormaPagamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                GridFormaPagamento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                //Fomatar datagrid
                BotonPesquisarUser_Click(sender, e);

                GridFormaPagamento.Columns["forma_id"].HeaderText = "Código";
                GridFormaPagamento.Columns["forma_id"].Width = 100;
                GridFormaPagamento.Columns["forma_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                GridFormaPagamento.Columns["forma_descricao"].HeaderText = "Descrição Forma de pagamento";
                GridFormaPagamento.Columns["forma_descricao"].Width = 750;

                //GridFormaPagamento.Columns["user_password"].HeaderText = "Senha do Usuário";
                //GridFormaPagamento.Columns["user_password"].Width = 150;
            }
        }

        public void CarregaUsuario(int codigo)
        {
            validacao_FormaPagamento valida = new validacao_FormaPagamento(conexao);
            GridFormaPagamento.DataSource = valida.CarregarFormaPagamento(codigo);
        }

        private void BotonPesquisarUser_Click(object sender, EventArgs e)
        {
             try
             {
                 validacao_FormaPagamento valida = new validacao_FormaPagamento(conexao);
                 GridFormaPagamento.DataSource = valida.ListarFormaPagamento(gridTextForma.Text);
             }
             catch (Exception ex)
             {
                throw ex;
             }
        }

        


        /// <summary>
        /// botão voltar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// gerador de arquivos PDF,WOED,EXCELL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonGerar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmdGerarArquivo.SelectedIndex) == -1)
            {
                MetroMessageBox.Show(this, "\n\n Selecione um fomrmato de documento", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "")
            {
                MetroMessageBox.Show(this, "\n\n Por favor selecione uma opção ", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar PDF")
            {

            
                MetroMessageBox.Show(this, "\n\n Documento PDF gerado com sucesso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar Word")
            {
                MetroMessageBox.Show(this, "\n\n Documento Word gerado com sucesso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar Excell")
            {
                MetroMessageBox.Show(this, "\n\n Documento Excell gerado com suceso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }


        private void GridFormaPagamento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridFormaPagamento.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }


    }
}
