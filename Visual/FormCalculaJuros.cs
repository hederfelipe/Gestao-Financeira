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
    public partial class FormCalculaJuros : MetroForm
    {

        /// <summary>
        /// Formula usada para calcular juros simples
        /// M*P.(1+(I.N))
        /// M=MONTANTE
        /// P=VALOR PRESENTE
        /// I=TAXA
        /// N=PERIODO
        /// </summary>
        public FormCalculaJuros()
        {
            InitializeComponent();
        }

        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        /// <summary>
        /// Formulario para calcular juros simples
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCalcular_Click(object sender, EventArgs e)        
        {
            double M = 0;
            double P = 0;
            double I = 0;
            double N = 0;

            try
            { 
                 P = Convert.ToDouble(txtValorParcela.Text);
                 I = Convert.ToDouble(txtTaxaJuros.Text);
                 N = Convert.ToDouble(txtDiasAtraso.Text);
                if(I >= 1)
                {
                    I = I / 100;
                }
                M = P * (1 + (I * (N / 30)));
                txtValorApagar.Text = M.ToString("C");
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n  Os valores não foram inseridos corretamente \n Detalhes: " + ex.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorParcela.Focus();
            }
  
        }

        

        private void BotonLimpar_Click(object sender, EventArgs e)
        {
            this.txtDiasAtraso.Text = "";
            this.txtTaxaJuros.Text = "";
            this.txtValorApagar.Text = "";
            this.txtValorParcela.Text = "";
        }

        /// <summary>
        /// Evento para formatar o campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if(txtValorParcela.Text.Contains(",") == false){
                txtValorParcela.Text += ",00";
            }
            else
            {
                if(txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }



        /// <summary>
        /// evento leave e keypress para taxa de juros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void txtValorApagar_Leave(object sender, EventArgs e)
        {

            if (txtValorApagar.Text.Contains(",") == false)
            {
                txtValorApagar.Text += ",00";
            }
            else
            {
                if (txtValorApagar.Text.IndexOf(",") == txtValorApagar.Text.Length - 1)
                {
                    txtValorApagar.Text += "00";
                }
            }
        }

        private void txtValorApagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorApagar.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        /// <summary>
        /// evento keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculaJuros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

   
    }
}
