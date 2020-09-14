using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using MetroFramework;
using GestaoFinanceira.Validacao;


namespace GestaoFinanceira.Visual
{
    public partial class formCadastroUsuario : MetroForm
    {

        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;

        

        public formCadastroUsuario()
        {
            InitializeComponent();
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
        /// metodo para verificar o usuario cadastrado
        /// </summary>
        /// <param name="usuario"></param>
        public void verificaUsuario(string usuario)
        {
            int r = 0;
            validacao_Usuario valida = new validacao_Usuario(conexao);
            r = valida.VerificarUsuario(txtUsuario.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n Ja existe Usuário cadastrado no sistema ", "VERIFICAÇÃO DE USUÁRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                txtUsuario.Focus();
            }
        }

        /// <summary>
        /// função habilita campos do formulario
        /// </summary>
        public void HabilitaCampos()
        {

            txtPassword.Enabled = true;
            txtUsuario.Enabled = true;
        }
        /// <summary>
        /// função desabilita campos do formulario
        /// </summary>
        public void DesabilitaCampos()
        {
            txtPassword.Enabled = false;
            txtUsuario.Enabled = false;
        }

        /// <summary>
        /// função para limpar os campos
        /// </summary>
        public void LimpaCampos()
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
            txtCodigo.Text = "";
        }

        /// <summary>
        /// Chama formulario de cadastro de usuario
        /// </summary> bota para voltar
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metodo do botao gravar / cadastrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void BotonNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.txtUsuario.Focus();
            this.AlteraBotao(2);
            this.HabilitaCampos();
        }

        /// <summary>
        /// metodo botao editar cadastro do usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEditar_Click(object sender, EventArgs e)
        {
           
                this.operacao = "alterar";
                this.HabilitaCampos();
                this.AlteraBotao(2);
                this.txtUsuario.Focus();
        }

        /// <summary>
        /// metodo para cancelar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.LimpaCampos();
            this.txtUsuario.Focus();
            this.AlteraBotao(1);
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Metodo para gravar usuario ao banco de dados
        /// </summary>
        private void BotonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario mod_usuario = new modelo_Usuario();
                mod_usuario.User_usuario = txtUsuario.Text;
                mod_usuario.User_password = txtPassword.Text;
                validacao_Usuario validacao_usuario = new validacao_Usuario(conexao);
                if (operacao == "cadastrar")
                {

                    validacao_usuario.SalvarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n Usuario Cadastrado com sucesso ", "CADASTRO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    mod_usuario.User_id = Convert.ToInt32(txtCodigo.Text);
                    validacao_usuario.EditarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n\n  Usuário Editado com sucesso! ", " USUÁRIO EDITADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao cadastrar um cliente! \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }

        }

        private void BotonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
                "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                    valida_usuario.ExcluirUsuario(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n  Usuário excluido com sucesso ",
                    "ESCLUSÃO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n Não foi possivel excluir usuário do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                this.AlteraBotao(3);
            }
        }



        private void BotonPesquisar_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario relatorio = new formRelatorioUsuario();
            relatorio.ShowDialog();
            if (relatorio.codigo != 0)
            {
                validacao_Usuario valida = new validacao_Usuario(conexao);
                modelo_Usuario usuario = valida.CarregarUsuario(relatorio.codigo);
                txtCodigo.Text = usuario.User_id.ToString();
                txtUsuario.Text = usuario.User_usuario;
                txtPassword.Text = usuario.User_password;
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtUsuario.Focus();
                AlteraBotao(1);
            }
            relatorio.Dispose();

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        /// <summary>
        /// evento para verificar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            verificaUsuario(usuario);
        }
    }
}
    

 


