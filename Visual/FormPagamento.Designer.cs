namespace GestaoFinanceira.Visual
{
    partial class FormPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonGravar = new MetroFramework.Controls.MetroButton();
            this.BotonPesquisar = new MetroFramework.Controls.MetroButton();
            this.BotonNovo = new MetroFramework.Controls.MetroButton();
            this.BotonExcluir = new MetroFramework.Controls.MetroButton();
            this.BotonEditar = new MetroFramework.Controls.MetroButton();
            this.BotonCancelar = new MetroFramework.Controls.MetroButton();
            this.BotonVoltar = new MetroFramework.Controls.MetroButton();
            this.txtPagamento = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonGravar
            // 
            this.BotonGravar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonGravar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons81_salvar_32;
            this.BotonGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonGravar.Location = new System.Drawing.Point(562, 404);
            this.BotonGravar.Name = "BotonGravar";
            this.BotonGravar.Size = new System.Drawing.Size(100, 32);
            this.BotonGravar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonGravar.TabIndex = 51;
            this.BotonGravar.Text = "      Gravar";
            this.BotonGravar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonGravar.UseSelectable = true;
            this.BotonGravar.UseStyleColors = true;
            this.BotonGravar.Click += new System.EventHandler(this.BotonGravar_Click);
            // 
            // BotonPesquisar
            // 
            this.BotonPesquisar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonPesquisar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.BotonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPesquisar.Location = new System.Drawing.Point(138, 404);
            this.BotonPesquisar.Name = "BotonPesquisar";
            this.BotonPesquisar.Size = new System.Drawing.Size(100, 32);
            this.BotonPesquisar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonPesquisar.TabIndex = 50;
            this.BotonPesquisar.Text = "      Pesquisar";
            this.BotonPesquisar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonPesquisar.UseSelectable = true;
            this.BotonPesquisar.UseStyleColors = true;
            this.BotonPesquisar.Click += new System.EventHandler(this.BotonPesquisar_Click);
            // 
            // BotonNovo
            // 
            this.BotonNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonNovo.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons81_cancelar_32;
            this.BotonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonNovo.Location = new System.Drawing.Point(32, 404);
            this.BotonNovo.Name = "BotonNovo";
            this.BotonNovo.Size = new System.Drawing.Size(100, 32);
            this.BotonNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonNovo.TabIndex = 49;
            this.BotonNovo.Text = "  Novo";
            this.BotonNovo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonNovo.UseSelectable = true;
            this.BotonNovo.UseStyleColors = true;
            this.BotonNovo.Click += new System.EventHandler(this.BotonNovo_Click);
            // 
            // BotonExcluir
            // 
            this.BotonExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonExcluir.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_excluir_32;
            this.BotonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonExcluir.Location = new System.Drawing.Point(456, 404);
            this.BotonExcluir.Name = "BotonExcluir";
            this.BotonExcluir.Size = new System.Drawing.Size(100, 32);
            this.BotonExcluir.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonExcluir.TabIndex = 48;
            this.BotonExcluir.Text = "      Excluir";
            this.BotonExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonExcluir.UseSelectable = true;
            this.BotonExcluir.UseStyleColors = true;
            this.BotonExcluir.Click += new System.EventHandler(this.BotonExcluir_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonEditar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_editar_321;
            this.BotonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonEditar.Location = new System.Drawing.Point(350, 404);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(100, 32);
            this.BotonEditar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonEditar.TabIndex = 47;
            this.BotonEditar.Text = "    Editar";
            this.BotonEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonEditar.UseSelectable = true;
            this.BotonEditar.UseStyleColors = true;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonCancelar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons81_cancelar_32;
            this.BotonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonCancelar.Location = new System.Drawing.Point(244, 404);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(100, 32);
            this.BotonCancelar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonCancelar.TabIndex = 46;
            this.BotonCancelar.Text = "       Cancelar";
            this.BotonCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonCancelar.UseSelectable = true;
            this.BotonCancelar.UseStyleColors = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonVoltar
            // 
            this.BotonVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BotonVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_duplo_para_a_esquerda_32;
            this.BotonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonVoltar.Location = new System.Drawing.Point(668, 404);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(100, 32);
            this.BotonVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonVoltar.TabIndex = 44;
            this.BotonVoltar.Text = "  Voltar";
            this.BotonVoltar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonVoltar.UseSelectable = true;
            this.BotonVoltar.UseStyleColors = true;
            this.BotonVoltar.Click += new System.EventHandler(this.BotonVoltar_Click);
            // 
            // txtPagamento
            // 
            // 
            // 
            // 
            this.txtPagamento.CustomButton.Image = null;
            this.txtPagamento.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.txtPagamento.CustomButton.Name = "";
            this.txtPagamento.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPagamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPagamento.CustomButton.TabIndex = 1;
            this.txtPagamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPagamento.CustomButton.UseSelectable = true;
            this.txtPagamento.CustomButton.Visible = false;
            this.txtPagamento.DisplayIcon = true;
            this.txtPagamento.Icon = global::GestaoFinanceira.Properties.Resources.icons8_pessoa_do_sexo_masculino_16;
            this.txtPagamento.Lines = new string[0];
            this.txtPagamento.Location = new System.Drawing.Point(163, 82);
            this.txtPagamento.MaxLength = 32767;
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.PasswordChar = '\0';
            this.txtPagamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPagamento.SelectedText = "";
            this.txtPagamento.SelectionLength = 0;
            this.txtPagamento.SelectionStart = 0;
            this.txtPagamento.ShortcutsEnabled = true;
            this.txtPagamento.Size = new System.Drawing.Size(393, 25);
            this.txtPagamento.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPagamento.TabIndex = 41;
            this.txtPagamento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPagamento.UseSelectable = true;
            this.txtPagamento.UseStyleColors = true;
            this.txtPagamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPagamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.DisplayIcon = true;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Icon = global::GestaoFinanceira.Properties.Resources.icons8_cardápio_16;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(32, 82);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(113, 25);
            this.txtCodigo.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.UseStyleColors = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(0, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Forma de pagamento";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonGravar);
            this.Controls.Add(this.BotonPesquisar);
            this.Controls.Add(this.BotonNovo);
            this.Controls.Add(this.BotonExcluir);
            this.Controls.Add(this.BotonEditar);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamento";
            this.Resizable = false;
            this.Text = "Forma de Pagamento";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BotonPesquisar;
        private MetroFramework.Controls.MetroButton BotonNovo;
        private MetroFramework.Controls.MetroButton BotonExcluir;
        private MetroFramework.Controls.MetroButton BotonEditar;
        private MetroFramework.Controls.MetroButton BotonCancelar;
        private MetroFramework.Controls.MetroButton BotonVoltar;
        private MetroFramework.Controls.MetroTextBox txtPagamento;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        internal MetroFramework.Controls.MetroButton BotonGravar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}