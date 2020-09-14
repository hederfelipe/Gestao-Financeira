using System;
using MetroFramework.Forms;
using GestaoFinanceira.Relatorio;

namespace GestaoFinanceira.Visual
{
    public partial class FormImprressao : MetroForm
    {
        public FormImprressao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// chama o formulario de impressao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buton_Click(object sender, EventArgs e)
        {
            FormImpressaoCadastroUsuario f = new FormImpressaoCadastroUsuario();
            f.ShowDialog();
            f.Dispose();

        }

        private void BotonCliente_Click(object sender, EventArgs e)
        {
            FomrImpressaoCadastroCliente f = new FomrImpressaoCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormImpressaPagamento f = new FormImpressaPagamento();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
