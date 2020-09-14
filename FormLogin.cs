using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace GestaoFinanceira
{
    public partial class FormLogin : MetroForm
    {
        /// <summary>
        /// variavel global  do formulario
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        modelo_Usuario modelo = new modelo_Usuario();
        public static string usuario_logado;

        public FormLogin()
        {
            InitializeComponent();
        }

        public void LogarSistema()
        {
            MySqlConnection cx = new MySqlConnection("server = localhost; database = gestaofinanceira; User ID = root; password = 816633");
            cx.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conectado = new MySqlConnection();
            cmd.Connection = cx;
            cmd.CommandText = "SELECT * FROM usuario WHERE user_usuario = @user_usuario and user_password = @user_password ";
            cmd.Parameters.Add("@user_usuario", MySqlDbType.Text).Value = txtUsuario.Text;
            cmd.Parameters.Add("@user_password", MySqlDbType.Text).Value = txtPassword.Text;
            MySqlDataReader ler = null;
            ler = cmd.ExecuteReader();
            if (ler.Read())
            {
                usuario_logado = txtUsuario.Text;
                formPrincipal f = new formPrincipal();
                f.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\n Usuário ou senha inválido, por favor tente novamente! " +
                "\n\n Ou entre em contato com o administrador do sistema.", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos(); txtUsuario.Focus();
            }
            cx.Close();
        }
    
        

        public void LimpaCampos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }


        private void txtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();         
            metroLabel8.Text = Application.ProductVersion;
        }

        private void txtEntrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPassword.Text))
             {
                MetroMessageBox.Show(this, "\n\n O campo usuário e senha são obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos(); 
                txtUsuario.Focus(); 
                return;
            }
            else
            {
                LogarSistema();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
