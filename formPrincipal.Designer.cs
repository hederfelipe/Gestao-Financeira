namespace GestaoFinanceira
{
    partial class formPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.botonImpressao = new MetroFramework.Controls.MetroButton();
            this.botonConfiguracao = new MetroFramework.Controls.MetroButton();
            this.botonBloco = new MetroFramework.Controls.MetroButton();
            this.botonExcell = new MetroFramework.Controls.MetroButton();
            this.botonWord = new MetroFramework.Controls.MetroButton();
            this.botonCalulculadora = new MetroFramework.Controls.MetroButton();
            this.botonSair = new MetroFramework.Controls.MetroButton();
            this.ButonRelatorioUsuario = new MetroFramework.Controls.MetroButton();
            this.BotonCalculadora = new MetroFramework.Controls.MetroButton();
            this.Control = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNome.Location = new System.Drawing.Point(180, 43);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 20);
            this.labelNome.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário conectado :";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.time_Tick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Black;
            this.labelData.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelData.Location = new System.Drawing.Point(23, 501);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 13);
            this.labelData.TabIndex = 17;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Black;
            this.labelHora.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelHora.Location = new System.Drawing.Point(20, 527);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 13);
            this.labelHora.TabIndex = 18;
            // 
            // botonImpressao
            // 
            this.botonImpressao.AllowDrop = true;
            this.botonImpressao.BackColor = System.Drawing.Color.Black;
            this.botonImpressao.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_printer_printing_clip_art_free_printer_buckle_material_5a8cee441820f2_0174915315191854760988;
            this.botonImpressao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonImpressao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.botonImpressao.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.botonImpressao.ForeColor = System.Drawing.SystemColors.Info;
            this.botonImpressao.Location = new System.Drawing.Point(249, 94);
            this.botonImpressao.Name = "botonImpressao";
            this.botonImpressao.Size = new System.Drawing.Size(87, 100);
            this.botonImpressao.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonImpressao.TabIndex = 19;
            this.botonImpressao.Text = "Imprimir";
            this.botonImpressao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonImpressao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonImpressao.UseSelectable = true;
            this.botonImpressao.UseStyleColors = true;
            this.botonImpressao.Click += new System.EventHandler(this.botonImpressao_Click);
            // 
            // botonConfiguracao
            // 
            this.botonConfiguracao.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.botonConfiguracao.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_computer_icons_directory_desktop_wallpaper_5ae15d775bcc98_068019671524718967376;
            this.botonConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonConfiguracao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonConfiguracao.Location = new System.Drawing.Point(720, 398);
            this.botonConfiguracao.Name = "botonConfiguracao";
            this.botonConfiguracao.Size = new System.Drawing.Size(78, 85);
            this.botonConfiguracao.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonConfiguracao.TabIndex = 14;
            this.botonConfiguracao.Text = "Configuração";
            this.botonConfiguracao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonConfiguracao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonConfiguracao.UseSelectable = true;
            this.botonConfiguracao.UseStyleColors = true;
            this.botonConfiguracao.Visible = false;
            // 
            // botonBloco
            // 
            this.botonBloco.AllowDrop = true;
            this.botonBloco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonBloco.BackColor = System.Drawing.Color.Black;
            this.botonBloco.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_regular_751;
            this.botonBloco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonBloco.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.botonBloco.ForeColor = System.Drawing.SystemColors.Info;
            this.botonBloco.Location = new System.Drawing.Point(26, 397);
            this.botonBloco.Name = "botonBloco";
            this.botonBloco.Size = new System.Drawing.Size(78, 85);
            this.botonBloco.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonBloco.TabIndex = 10;
            this.botonBloco.Text = "B. Notas";
            this.botonBloco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonBloco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonBloco.UseSelectable = true;
            this.botonBloco.UseStyleColors = true;
            this.botonBloco.Click += new System.EventHandler(this.botonBloco_Click);
            // 
            // botonExcell
            // 
            this.botonExcell.AllowDrop = true;
            this.botonExcell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonExcell.BackColor = System.Drawing.Color.Black;
            this.botonExcell.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_ms_excel_75;
            this.botonExcell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonExcell.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.botonExcell.ForeColor = System.Drawing.SystemColors.Info;
            this.botonExcell.Location = new System.Drawing.Point(284, 398);
            this.botonExcell.Name = "botonExcell";
            this.botonExcell.Size = new System.Drawing.Size(78, 85);
            this.botonExcell.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonExcell.TabIndex = 9;
            this.botonExcell.Text = "Excell";
            this.botonExcell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonExcell.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonExcell.UseSelectable = true;
            this.botonExcell.UseStyleColors = true;
            this.botonExcell.Click += new System.EventHandler(this.botonExcell_Click);
            // 
            // botonWord
            // 
            this.botonWord.AllowDrop = true;
            this.botonWord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonWord.BackColor = System.Drawing.Color.Black;
            this.botonWord.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_ms_word_75;
            this.botonWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.botonWord.ForeColor = System.Drawing.SystemColors.Info;
            this.botonWord.Location = new System.Drawing.Point(200, 398);
            this.botonWord.Name = "botonWord";
            this.botonWord.Size = new System.Drawing.Size(78, 85);
            this.botonWord.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonWord.TabIndex = 8;
            this.botonWord.Text = "Word";
            this.botonWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonWord.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonWord.UseSelectable = true;
            this.botonWord.UseStyleColors = true;
            this.botonWord.Click += new System.EventHandler(this.botonWord_Click);
            // 
            // botonCalulculadora
            // 
            this.botonCalulculadora.AllowDrop = true;
            this.botonCalulculadora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonCalulculadora.BackColor = System.Drawing.Color.Black;
            this.botonCalulculadora.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_calculadora_752;
            this.botonCalulculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonCalulculadora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.botonCalulculadora.ForeColor = System.Drawing.SystemColors.Info;
            this.botonCalulculadora.Location = new System.Drawing.Point(112, 397);
            this.botonCalulculadora.Name = "botonCalulculadora";
            this.botonCalulculadora.Size = new System.Drawing.Size(78, 85);
            this.botonCalulculadora.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonCalulculadora.TabIndex = 7;
            this.botonCalulculadora.Text = "Calculadora";
            this.botonCalulculadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCalulculadora.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonCalulculadora.UseSelectable = true;
            this.botonCalulculadora.UseStyleColors = true;
            this.botonCalulculadora.Click += new System.EventHandler(this.botonCalulculadora_Click);
            // 
            // botonSair
            // 
            this.botonSair.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.botonSair.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_computer_icons_button_power_symbol_clip_art_20_off_5b43e887b802c1_4079305915311770957537;
            this.botonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSair.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.botonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonSair.Location = new System.Drawing.Point(831, 397);
            this.botonSair.Name = "botonSair";
            this.botonSair.Size = new System.Drawing.Size(78, 85);
            this.botonSair.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonSair.TabIndex = 6;
            this.botonSair.Text = "Sair";
            this.botonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonSair.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonSair.UseSelectable = true;
            this.botonSair.UseStyleColors = true;
            this.botonSair.Click += new System.EventHandler(this.botonSair_Click);
            // 
            // ButonRelatorioUsuario
            // 
            this.ButonRelatorioUsuario.AllowDrop = true;
            this.ButonRelatorioUsuario.BackColor = System.Drawing.Color.Black;
            this.ButonRelatorioUsuario.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_chart_search_engine_optimization_business_dispatch_market_survey_report_5a7a99f5438bf2_5008454615179842452767;
            this.ButonRelatorioUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonRelatorioUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButonRelatorioUsuario.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ButonRelatorioUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.ButonRelatorioUsuario.Location = new System.Drawing.Point(156, 94);
            this.ButonRelatorioUsuario.Name = "ButonRelatorioUsuario";
            this.ButonRelatorioUsuario.Size = new System.Drawing.Size(87, 100);
            this.ButonRelatorioUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.ButonRelatorioUsuario.TabIndex = 0;
            this.ButonRelatorioUsuario.Text = "Relatorio";
            this.ButonRelatorioUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButonRelatorioUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ButonRelatorioUsuario.UseSelectable = true;
            this.ButonRelatorioUsuario.UseStyleColors = true;
            this.ButonRelatorioUsuario.Click += new System.EventHandler(this.ButonRelatorio_Click);
            // 
            // BotonCalculadora
            // 
            this.BotonCalculadora.AllowDrop = true;
            this.BotonCalculadora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCalculadora.BackColor = System.Drawing.Color.Black;
            this.BotonCalculadora.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_blue_square_angle_area_utilities_calculator_5ab0df366994e3_5359562915215409184325;
            this.BotonCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCalculadora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BotonCalculadora.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BotonCalculadora.ForeColor = System.Drawing.SystemColors.Info;
            this.BotonCalculadora.Location = new System.Drawing.Point(63, 200);
            this.BotonCalculadora.Name = "BotonCalculadora";
            this.BotonCalculadora.Size = new System.Drawing.Size(273, 179);
            this.BotonCalculadora.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonCalculadora.TabIndex = 1;
            this.BotonCalculadora.Text = "Calcular juros";
            this.BotonCalculadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCalculadora.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonCalculadora.UseSelectable = true;
            this.BotonCalculadora.UseStyleColors = true;
            this.BotonCalculadora.Click += new System.EventHandler(this.BotonCalculadora_Click);
            // 
            // Control
            // 
            this.Control.AllowDrop = true;
            this.Control.BackColor = System.Drawing.Color.Black;
            this.Control.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_computer_icons_portable_network_graphics_clip_art_forecast_task_icons_5c6f4546468557_7913797915507961022889;
            this.Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Control.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Control.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Control.ForeColor = System.Drawing.SystemColors.Info;
            this.Control.Location = new System.Drawing.Point(63, 94);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(87, 100);
            this.Control.Style = MetroFramework.MetroColorStyle.Blue;
            this.Control.TabIndex = 0;
            this.Control.Text = "\r\nCadastro";
            this.Control.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Control.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Control.UseSelectable = true;
            this.Control.UseStyleColors = true;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.botonImpressao);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.botonConfiguracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.botonBloco);
            this.Controls.Add(this.botonExcell);
            this.Controls.Add(this.botonWord);
            this.Controls.Add(this.botonCalulculadora);
            this.Controls.Add(this.botonSair);
            this.Controls.Add(this.ButonRelatorioUsuario);
            this.Controls.Add(this.BotonCalculadora);
            this.Controls.Add(this.Control);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = " Gestão Financeira";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Control;
        private MetroFramework.Controls.MetroButton ButonRelatorioUsuario;
        private MetroFramework.Controls.MetroButton BotonCalculadora;
        private MetroFramework.Controls.MetroButton botonSair;
        private MetroFramework.Controls.MetroButton botonCalulculadora;
        private MetroFramework.Controls.MetroButton botonWord;
        private MetroFramework.Controls.MetroButton botonExcell;
        private MetroFramework.Controls.MetroButton botonBloco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton botonConfiguracao;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private MetroFramework.Controls.MetroButton botonImpressao;
    }
}

