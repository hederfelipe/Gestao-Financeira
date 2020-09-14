using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GestaoFinanceira.Visual
{
    public partial class FormRelatorio : MetroForm
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }


        private void BotonRelatorioUsuario_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario f = new formRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// ação que chama a tela de relatorio de forma de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonFormaPagamento_Click(object sender, EventArgs e)
        {
            FormRelatorioFormaPagamento f = new FormRelatorioFormaPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void BotonRelatorioCliente_Click(object sender, EventArgs e)
        {
            FormRelatorio_Cliente f = new FormRelatorio_Cliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
