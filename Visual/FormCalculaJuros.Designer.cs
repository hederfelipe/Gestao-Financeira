namespace GestaoFinanceira.Visual
{
    partial class FormCalculaJuros
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
            this.txtValorApagar = new MetroFramework.Controls.MetroTextBox();
            this.txtDiasAtraso = new MetroFramework.Controls.MetroTextBox();
            this.txtTaxaJuros = new MetroFramework.Controls.MetroTextBox();
            this.txtValorParcela = new MetroFramework.Controls.MetroTextBox();
            this.BotonLimpar = new MetroFramework.Controls.MetroButton();
            this.BotonCalcular = new MetroFramework.Controls.MetroButton();
            this.BotonVoltar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorApagar
            // 
            // 
            // 
            // 
            this.txtValorApagar.CustomButton.Image = null;
            this.txtValorApagar.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtValorApagar.CustomButton.Name = "";
            this.txtValorApagar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValorApagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorApagar.CustomButton.TabIndex = 1;
            this.txtValorApagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorApagar.CustomButton.UseSelectable = true;
            this.txtValorApagar.CustomButton.Visible = false;
            this.txtValorApagar.DisplayIcon = true;
            this.txtValorApagar.ForeColor = System.Drawing.Color.Red;
            this.txtValorApagar.Icon = global::GestaoFinanceira.Properties.Resources.icons8_real_18;
            this.txtValorApagar.Lines = new string[0];
            this.txtValorApagar.Location = new System.Drawing.Point(169, 181);
            this.txtValorApagar.MaxLength = 32767;
            this.txtValorApagar.Name = "txtValorApagar";
            this.txtValorApagar.PasswordChar = '\0';
            this.txtValorApagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorApagar.SelectedText = "";
            this.txtValorApagar.SelectionLength = 0;
            this.txtValorApagar.SelectionStart = 0;
            this.txtValorApagar.ShortcutsEnabled = true;
            this.txtValorApagar.Size = new System.Drawing.Size(185, 25);
            this.txtValorApagar.Style = MetroFramework.MetroColorStyle.Red;
            this.txtValorApagar.TabIndex = 19;
            this.txtValorApagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorApagar.UseSelectable = true;
            this.txtValorApagar.UseStyleColors = true;
            this.txtValorApagar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorApagar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorApagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorApagar_KeyPress);
            this.txtValorApagar.Leave += new System.EventHandler(this.txtValorApagar_Leave);
            // 
            // txtDiasAtraso
            // 
            // 
            // 
            // 
            this.txtDiasAtraso.CustomButton.Image = null;
            this.txtDiasAtraso.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtDiasAtraso.CustomButton.Name = "";
            this.txtDiasAtraso.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDiasAtraso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiasAtraso.CustomButton.TabIndex = 1;
            this.txtDiasAtraso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.CustomButton.UseSelectable = true;
            this.txtDiasAtraso.CustomButton.Visible = false;
            this.txtDiasAtraso.DisplayIcon = true;
            this.txtDiasAtraso.ForeColor = System.Drawing.Color.Red;
            this.txtDiasAtraso.Icon = global::GestaoFinanceira.Properties.Resources.icons8_moedas_16;
            this.txtDiasAtraso.Lines = new string[0];
            this.txtDiasAtraso.Location = new System.Drawing.Point(169, 139);
            this.txtDiasAtraso.MaxLength = 32767;
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.PasswordChar = '\0';
            this.txtDiasAtraso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiasAtraso.SelectedText = "";
            this.txtDiasAtraso.SelectionLength = 0;
            this.txtDiasAtraso.SelectionStart = 0;
            this.txtDiasAtraso.ShortcutsEnabled = true;
            this.txtDiasAtraso.Size = new System.Drawing.Size(185, 25);
            this.txtDiasAtraso.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDiasAtraso.TabIndex = 18;
            this.txtDiasAtraso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.UseSelectable = true;
            this.txtDiasAtraso.UseStyleColors = true;
            this.txtDiasAtraso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiasAtraso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTaxaJuros
            // 
            // 
            // 
            // 
            this.txtTaxaJuros.CustomButton.Image = null;
            this.txtTaxaJuros.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtTaxaJuros.CustomButton.Name = "";
            this.txtTaxaJuros.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTaxaJuros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaxaJuros.CustomButton.TabIndex = 1;
            this.txtTaxaJuros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuros.CustomButton.UseSelectable = true;
            this.txtTaxaJuros.CustomButton.Visible = false;
            this.txtTaxaJuros.DisplayIcon = true;
            this.txtTaxaJuros.ForeColor = System.Drawing.Color.Red;
            this.txtTaxaJuros.Icon = global::GestaoFinanceira.Properties.Resources.icons8_buscador_de_desconto_16;
            this.txtTaxaJuros.Lines = new string[0];
            this.txtTaxaJuros.Location = new System.Drawing.Point(169, 98);
            this.txtTaxaJuros.MaxLength = 32767;
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.PasswordChar = '\0';
            this.txtTaxaJuros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaxaJuros.SelectedText = "";
            this.txtTaxaJuros.SelectionLength = 0;
            this.txtTaxaJuros.SelectionStart = 0;
            this.txtTaxaJuros.ShortcutsEnabled = true;
            this.txtTaxaJuros.Size = new System.Drawing.Size(185, 25);
            this.txtTaxaJuros.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTaxaJuros.TabIndex = 17;
            this.txtTaxaJuros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuros.UseSelectable = true;
            this.txtTaxaJuros.UseStyleColors = true;
            this.txtTaxaJuros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaxaJuros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValorParcela
            // 
            // 
            // 
            // 
            this.txtValorParcela.CustomButton.Image = null;
            this.txtValorParcela.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtValorParcela.CustomButton.Name = "";
            this.txtValorParcela.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValorParcela.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorParcela.CustomButton.TabIndex = 1;
            this.txtValorParcela.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.CustomButton.UseSelectable = true;
            this.txtValorParcela.CustomButton.Visible = false;
            this.txtValorParcela.DisplayIcon = true;
            this.txtValorParcela.ForeColor = System.Drawing.Color.Red;
            this.txtValorParcela.Icon = global::GestaoFinanceira.Properties.Resources.icons8_real_181;
            this.txtValorParcela.Lines = new string[0];
            this.txtValorParcela.Location = new System.Drawing.Point(169, 60);
            this.txtValorParcela.MaxLength = 32767;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.PasswordChar = '\0';
            this.txtValorParcela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorParcela.SelectedText = "";
            this.txtValorParcela.SelectionLength = 0;
            this.txtValorParcela.SelectionStart = 0;
            this.txtValorParcela.ShortcutsEnabled = true;
            this.txtValorParcela.Size = new System.Drawing.Size(185, 25);
            this.txtValorParcela.Style = MetroFramework.MetroColorStyle.Red;
            this.txtValorParcela.TabIndex = 16;
            this.txtValorParcela.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.UseSelectable = true;
            this.txtValorParcela.UseStyleColors = true;
            this.txtValorParcela.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorParcela.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
            // 
            // BotonLimpar
            // 
            this.BotonLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonLimpar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_voltar_321;
            this.BotonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonLimpar.Location = new System.Drawing.Point(23, 245);
            this.BotonLimpar.Name = "BotonLimpar";
            this.BotonLimpar.Size = new System.Drawing.Size(100, 32);
            this.BotonLimpar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonLimpar.TabIndex = 11;
            this.BotonLimpar.Text = "Limpar";
            this.BotonLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonLimpar.UseSelectable = true;
            this.BotonLimpar.UseStyleColors = true;
            this.BotonLimpar.Click += new System.EventHandler(this.BotonLimpar_Click);
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonCalcular.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_aceitar_banco_de_dados_32;
            this.BotonCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCalcular.Location = new System.Drawing.Point(151, 245);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(100, 32);
            this.BotonCalcular.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonCalcular.TabIndex = 10;
            this.BotonCalcular.Text = "      Calcular";
            this.BotonCalcular.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonCalcular.UseSelectable = true;
            this.BotonCalcular.UseStyleColors = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // BotonVoltar
            // 
            this.BotonVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_duplo_para_a_esquerda_32;
            this.BotonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonVoltar.Location = new System.Drawing.Point(277, 245);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(100, 32);
            this.BotonVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonVoltar.TabIndex = 9;
            this.BotonVoltar.Text = "  Voltar";
            this.BotonVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonVoltar.UseSelectable = true;
            this.BotonVoltar.UseStyleColors = true;
            this.BotonVoltar.Click += new System.EventHandler(this.BotonVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(2, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Taxa de juros (Ao Mês)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Dias de atraso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Valor à pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Valor da Parcela";
            // 
            // FormCalculaJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorApagar);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.BotonLimpar);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculaJuros";
            this.Resizable = false;
            this.Text = "Calcula  juros ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalculaJuros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BotonVoltar;
        private MetroFramework.Controls.MetroButton BotonCalcular;
        private MetroFramework.Controls.MetroButton BotonLimpar;
        private MetroFramework.Controls.MetroTextBox txtValorParcela;
        private MetroFramework.Controls.MetroTextBox txtTaxaJuros;
        private MetroFramework.Controls.MetroTextBox txtDiasAtraso;
        private MetroFramework.Controls.MetroTextBox txtValorApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}