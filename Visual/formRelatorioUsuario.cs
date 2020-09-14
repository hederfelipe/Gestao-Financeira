using System;
using MetroFramework.Forms;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Validacao;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using System.Linq;

namespace GestaoFinanceira.Visual
{
    public partial class formRelatorioUsuario : MetroForm
    {
        public int codigo = 0;

        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);


        /// <summary>
        /// Variavel global da classe
        /// </summary>


        public formRelatorioUsuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// metodo do botão voltar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo Load do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FromRelatorioUsuario_Load(object sender, EventArgs e)
        {
            cmdGerarArquivo.Items.Insert(0, "");
            cmdGerarArquivo.Items.Insert(1, "Gerar PDF");
            cmdGerarArquivo.Items.Insert(2, "Gerar Excel");
            cmdGerarArquivo.Items.Insert(3, "Gerar Word");


            // Mudar cor do Grid
            GridUsuario.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            GridUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            GridUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            GridUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //Fomatar datagrid
            BotonPesquisarUser_Click(sender, e);

            GridUsuario.Columns["user_id"].HeaderText = "Código";
            GridUsuario.Columns["user_id"].Width = 70;
            GridUsuario.Columns["user_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            GridUsuario.Columns["user_usuario"].HeaderText = "Nome do Usuário";
            GridUsuario.Columns["user_usuario"].Width = 500;

            GridUsuario.Columns["user_password"].HeaderText = "Senha do Usuário";
            GridUsuario.Columns["user_password"].Width = 150;
        }

        /// <summary>
        /// chama tela de relatorio de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPesquisarUser_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Usuario valida = new validacao_Usuario(conexao);
                GridUsuario.DataSource = valida.ListarUsuario(gridText.Text);      
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CarregaUsuario(int codigo)
        {
            validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
            GridUsuario.DataSource = valida_usuario.CarregarUsuario(codigo);
        }

        /// <summary>
        /// duplo click no grid do usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridUsuario.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
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
                /*document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText = "Hello World...\nFrom DynamicPDF Generator for .NET\nDynamicPDF.com";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);

            document.Draw(@"C:\Output.pdf");
            */
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
       
    }
}

