using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Valicadao;
using MetroFramework;
using GestaoFinanceira.Modelo;


namespace GestaoFinanceira.Visual
{
    public partial class FormCadastroCliente : MetroForm
    {
        /// <summary>
        /// variavel global
        /// </summary>
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        Utilidade_FormataCampos utilidade_formataCampos = new Utilidade_FormataCampos();
        Utilidade_ValidaCep valida_cep = new Utilidade_ValidaCep();
        Utilidade_ValidaCpf valida_cpf = new Utilidade_ValidaCpf();
        
        string usuario, operacao;

        

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

            /// <summary>
            /// função para alterar os botoões
            /// </summary>
            /// <param name="op"></param>
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
        /// metodo para habilitar campos
        /// </summary>
        public void HabilitaCampos()
        {

            txtData.Enabled = true;
            txtCPF.Enabled = true; 
            txtNomeCliente.Enabled = true; 
            txtCEP.Enabled = true; 
            txtEndereco.Enabled = true; 
            txtComplemento.Enabled = true; 
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtEstado.Enabled = true; 
            txtEmail.Enabled = true; 
            txtTelefone.Enabled = true; 
            txtTelefone.Enabled = true; 
            txtCidade.Enabled = true;
            txtIbservacao.Enabled = true;
            this.txtData.Focus();



        }
        /// <summary>
        /// função desabilita campos do formulario
        /// </summary>
        public void DesabilitaCampos()
        {
            txtData.Enabled = false;
            txtCPF.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCEP.Enabled = false;
            txtEndereco.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtEstado.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtTelefone.Enabled = false;
            txtCidade.Enabled = false;
            txtIbservacao.Enabled = false;
            this.txtData.Focus();


        }

        /// <summary>
        /// função para limpar os campos
        /// </summary>
        public void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtData.Text = "";
            txtCPF.Text = "";
            txtNomeCliente.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtEstado.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
            txtIbservacao.Text = "";
        }

        private void FormCadastro_Cliente_Load(object sender, EventArgs e)
        {
            this.labelCpfInvalido.Visible = false;
            this.DesabilitaCampos();
            this.AlteraBotao(1);

        }

        /// <summary>
        /// metodo para cancelar a operação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.LimpaCampos();
            this.txtData.Focus();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Boto para novo cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.txtData.Focus();
            this.AlteraBotao(2);
            this.HabilitaCampos();
        }

        /// <summary>
        /// metodo para voltar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        /// <summary>
        /// Metodo para o evento de editar o cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtData.Focus();
        }

        /// <summary>
        /// metodo para evento botão gravar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Cliente mod_cliente = new modelo_Cliente();
                mod_cliente.Cli_dataCadastro = Convert.ToDateTime(txtData.Text);
                mod_cliente.Cli_cpf = txtCPF.Text;
                mod_cliente.Cli_nome = txtNomeCliente.Text;
                mod_cliente.Cli_cep = txtCEP.Text;
                mod_cliente.Cli_endereco = txtEndereco.Text;
                mod_cliente.Cli_numero = Convert.ToInt32(txtNumero.Text);
                mod_cliente.Cli_complemento = txtComplemento.Text;
                mod_cliente.Cli_bairro = txtBairro.Text;
                mod_cliente.Cli_cidade = txtCidade.Text;
                mod_cliente.Cli_estado = txtEstado.Text;
                mod_cliente.Cli_email = txtEmail.Text;
                mod_cliente.Cli_foneCelular = txtTelefone.Text;
                mod_cliente.Cli_observacao = txtIbservacao.Text;               
                validacao_Cliente validacao_cliente = new validacao_Cliente(conexao);
                if (operacao == "cadastrar")
                {

                    validacao_cliente.SalvarCliente(mod_cliente);
                    MetroMessageBox.Show(this, "\n Cliente Cadastrado com sucesso ", "CADASTRO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    mod_cliente.Cli_id = Convert.ToInt32(txtCodigo.Text);
                    validacao_cliente.EditarCliente(mod_cliente);
                    MetroMessageBox.Show(this, "\n\n  Cliente Editado com sucesso! ", " USUÁRIO EDITADO",
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

        /// <summary>
        /// metodo para editar o cadastro do cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPesquisar_Click(object sender, EventArgs e)
        {
            FormRelatorio_Cliente relatorio = new FormRelatorio_Cliente();
            relatorio.ShowDialog();
            if (relatorio.codigo != 0)
            {
                validacao_Cliente valida = new validacao_Cliente(conexao);
                modelo_Cliente cliente = valida.CarregarCliente(relatorio.codigo);
                txtCodigo.Text = cliente.Cli_id.ToString();
                txtData.Text = cliente.Cli_dataCadastro.ToShortDateString();
                txtCPF.Text = cliente.Cli_cpf;
                txtNomeCliente.Text = cliente.Cli_nome;
                txtCEP.Text = cliente.Cli_cep;
                txtEndereco.Text = cliente.Cli_endereco;
                txtNumero.Text = cliente.Cli_numero.ToString();
                txtComplemento.Text = cliente.Cli_complemento;
                txtBairro.Text = cliente.Cli_bairro;
                txtCidade.Text = cliente.Cli_cidade;
                txtEstado.Text = cliente.Cli_estado;
                txtTelefone.Text = cliente.Cli_foneCelular;
                txtEmail.Text = cliente.Cli_email;
                txtIbservacao.Text = cliente.Cli_observacao;
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtData.Focus();
                AlteraBotao(1);
            }
            relatorio.Dispose();
        }

        
        /// <summary>
        /// Metodo para excluir cliente do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
                "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                    valida_cliente.ExcluirCliente(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n  Cliente excluido com sucesso ",
                    "ESCLUSÃO DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n Não foi possivel excluir o cliente do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCodigo.Focus();
                this.AlteraBotao(3);
            }
        }

        /// <summary>
        /// metodo para verificar se ja existe cpf cadastrado no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        public void VerificarCPF(string usuario)
        {
            string cpfFormat = txtCPF.Text;
            {
                int r = 0;
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                r = valida_cliente.VerificarCliente(txtCPF.Text);
                if (r > 0)
                {
                    MetroMessageBox.Show(this, "\n\n Já existe o CPF  " + cpfFormat + "  do cliente cadastrado no sistema.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Text = "";
                    txtCPF.Focus();
                }
            }
        }

        /// <summary>
        /// evento para inserir keypress do cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.CEP;
                utilidade_formataCampos.Mascara(edit, txtCEP);
            }
        }

        /// <summary>
        /// metodo keypress do CPF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.CPF;
                utilidade_formataCampos.Mascara(edit, txtCPF);
            }
        }

        /// <summary>
        /// metodo para keypress do DATA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.DATA;
                utilidade_formataCampos.Mascara(edit, txtData);
            }
        }

        /// <summary>
        /// keypress do telefone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.TELEFONE;
                utilidade_formataCampos.Mascara(edit, txtTelefone);
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {

            if (valida_cep.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = Utilidade_ValidaCep.bairro;
                txtEstado.Text = Utilidade_ValidaCep.estado;
                txtCidade.Text = Utilidade_ValidaCep.cidade;
                txtEndereco.Text = Utilidade_ValidaCep.endereco;
                txtComplemento.Text = Utilidade_ValidaCep.complemento;
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            VerificarCPF(usuario);
            if (labelCpfInvalido.Visible == false)
            {
                if(valida_cpf.ValidaCPF(txtCPF.Text) == false)
                {
                    labelCpfInvalido.Visible = true;   
                }
                if (txtCPF.Text == "")
                {
                    labelCpfInvalido.Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// metodo keydow / enter para pular de caixa de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
