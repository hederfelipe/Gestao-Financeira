using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Valicadao;
using GestaoFinanceira.Utilidade;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class FormRelatorio_Cliente : MetroForm
    {

        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public FormRelatorio_Cliente()
        {
            InitializeComponent();
        }

      

        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metodo que executa o formulario load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRelatorio_Cliente_Load(object sender, EventArgs e)
        {
            {
                cmdGerarArquivo.Items.Insert(0, "");
                cmdGerarArquivo.Items.Insert(1, "Gerar PDF");
                cmdGerarArquivo.Items.Insert(2, "Gerar Excel");
                cmdGerarArquivo.Items.Insert(3, "Gerar Word");


                // Mudar cor do Grid
                GridCliente.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                GridCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                GridCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                GridCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                CarregarCliente(codigo);

                //Fomatar datagrid
                BotonPesquisarCliente_Click(sender, e);

                GridCliente.Columns["cli_id"].HeaderText = "Código";
                GridCliente.Columns["cli_id"].Width = 70;
                GridCliente.Columns["cli_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                GridCliente.Columns["cli_dataCadastro"].HeaderText = "Data de cadastro";
                GridCliente.Columns["cli_dataCadastro"].Width = 150;

                GridCliente.Columns["cli_cpf"].HeaderText = "CPF do Cliente";
                GridCliente.Columns["cli_cpf"].Width = 150;

                GridCliente.Columns["cli_nome"].HeaderText = "Nome do Cliente";
                GridCliente.Columns["cli_nome"].Width = 200;

                GridCliente.Columns["cli_foneCelular"].HeaderText = "Telefone do Cliente";
                GridCliente.Columns["cli_foneCelular"].Width = 150;


                //metodo para desabilitas/ocultar outras colunas

                GridCliente.Columns["cli_cep"].Visible = false;
                GridCliente.Columns["cli_endereco"].Visible = false;
                GridCliente.Columns["cli_numero"].Visible = false;
                GridCliente.Columns["cli_complemento"].Visible = false;
                GridCliente.Columns["cli_bairro"].Visible = false;
                GridCliente.Columns["cli_cidade"].Visible = false;
                GridCliente.Columns["cli_estado"].Visible = false;
                GridCliente.Columns["cli_email"].Visible = false;
                GridCliente.Columns["cli_observacao"].Visible = false;



            }
        }

        public void CarregarCliente(int codigo)
        {
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            GridCliente.DataSource = valida_cliente.CarregarCliente(codigo);
        }

        private void BotonPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Cliente valida = new validacao_Cliente(conexao);
                GridCliente.DataSource = valida.ListarCliente(gridTextForma.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


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


        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCliente.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
        
    }  
    
}
