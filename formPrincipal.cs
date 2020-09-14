using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Visual;
using MetroFramework;
using System.Diagnostics;

namespace GestaoFinanceira
{

    public partial class formPrincipal : MetroForm
    {
        FormLogin Login = new FormLogin();
        private string data = "Data : "+ DateTime.Now.ToShortDateString();
        private string hora = "Hora : "+ DateTime.Now.ToShortTimeString();
        Timer t = new Timer();
        public formPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Control_Click(object sender, EventArgs e)
        {
            formCadastro f = new formCadastro();
            f.ShowDialog();
            f.Dispose();

        }

       private void ButonRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio f = new FormRelatorio();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// metodo do fomrulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formPrincipal_Load(object sender, EventArgs e)
        {
            CarregaUsuarioLogado();
            if(FormLogin.usuario_logado == "Heder Felipe")
            {
                AutorizacaoUsuario();
            }
            t.Interval = 1000;
            t.Tick += new EventHandler(this.time_Tick);
            t.Start();
            CarregaUsuarioLogado();
            Data();
        }

        /// <summary>
        /// metodo data 
        /// </summary>
        public void Data()
        {
            labelData.Text = data;
        }

       


        public void AutorizacaoUsuario()
        {
            botonConfiguracao.Visible = true;
        }
        private void CarregaUsuarioLogado()
        {
            labelNome.Text = FormLogin.usuario_logado;
        }
        private void BotonCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculaJuros f = new FormCalculaJuros();
            f.ShowDialog();
            f.Dispose();
        }

        private void botonSair_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Realmente desejar sair do sistema ?",
               "Abondonar o sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        /// <summary>
        /// metodo para chamar a calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCalulculadora_Click(object sender, EventArgs e)
        {

            Process.Start("Calc.exe");
        }
        /// <summary>
        /// metodo chama word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void botonExcell_Click(object sender, EventArgs e)
        {
            Process.Start("excel");

        }

        private void botonBloco_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// metodo para traser a hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour; 
            int mm = DateTime.Now.Minute; 
            int ss = DateTime.Now.Second; string time = "";
            if (hh < 10) { time += "0" + hh;
            } 
            else 
            { 
                time += hh;
            }
            time += ":"; 
            if (mm < 10) 
            {
                time += "0" + mm;
            } else
            { 
                time += mm; 
            }
            time += ":";
            if (ss < 10) 
            { 
                time += "0" + ss;
            } 
            else 
            {
                time += ss;
            }
            labelHora.Text = "Hora : " + time;
        }

        /// <summary>
        /// metodo para chamar formulario de impressão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonImpressao_Click(object sender, EventArgs e)
        {
            FormImprressao f = new FormImprressao();
            f.ShowDialog();
            f.Dispose();

        }
    }
}
