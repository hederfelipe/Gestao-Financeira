using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace GestaoFinanceira.Visual
{
    public partial class formCadastro : MetroForm
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// cadastro de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCadastroUsuario_Click(object sender, EventArgs e)
        {
            formCadastroUsuario f = new formCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// cadastro de forma de pagamentos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPagamento_Click(object sender, EventArgs e)
        {
            FormPagamento f = new FormPagamento();
            f.ShowDialog();
            f.Dispose();

        }

        /// <summary>
        /// cadastro de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente f = new FormCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

    

        /// <summary>
        /// cadastro para chamar o formulario de empresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEmpresa_Click(object sender, EventArgs e)
        {
            FormCadastroEmpresa f = new FormCadastroEmpresa();
            f.Show();
            f.Dispose();

        }

       

    }
}
