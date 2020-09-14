namespace GestaoFinanceira.Visual
{
    partial class FormRelatorioFormaPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            this.GridFormaPagamento = new MetroFramework.Controls.MetroGrid();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.BotonPesquisarCliente = new MetroFramework.Controls.MetroButton();
            this.BotonGerar = new MetroFramework.Controls.MetroButton();
            this.BotonVoltar = new MetroFramework.Controls.MetroButton();
            this.gridTextForma = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGerarArquivo
            // 
            this.cmdGerarArquivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGerarArquivo.FormattingEnabled = true;
            this.cmdGerarArquivo.ItemHeight = 23;
            this.cmdGerarArquivo.Location = new System.Drawing.Point(51, 367);
            this.cmdGerarArquivo.Name = "cmdGerarArquivo";
            this.cmdGerarArquivo.Size = new System.Drawing.Size(100, 29);
            this.cmdGerarArquivo.TabIndex = 21;
            this.cmdGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdGerarArquivo.UseSelectable = true;
            // 
            // GridFormaPagamento
            // 
            this.GridFormaPagamento.AllowUserToAddRows = false;
            this.GridFormaPagamento.AllowUserToDeleteRows = false;
            this.GridFormaPagamento.AllowUserToResizeRows = false;
            this.GridFormaPagamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFormaPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridFormaPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFormaPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFormaPagamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridFormaPagamento.EnableHeadersVisualStyles = false;
            this.GridFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridFormaPagamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFormaPagamento.Location = new System.Drawing.Point(51, 120);
            this.GridFormaPagamento.Name = "GridFormaPagamento";
            this.GridFormaPagamento.ReadOnly = true;
            this.GridFormaPagamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFormaPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridFormaPagamento.RowHeadersVisible = false;
            this.GridFormaPagamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFormaPagamento.Size = new System.Drawing.Size(718, 241);
            this.GridFormaPagamento.Style = MetroFramework.MetroColorStyle.Silver;
            this.GridFormaPagamento.TabIndex = 19;
            this.GridFormaPagamento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GridFormaPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFormaPagamento_CellContentDoubleClick);
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel.Location = new System.Drawing.Point(51, 89);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(83, 25);
            this.metroLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel.TabIndex = 18;
            this.metroLabel.Text = "Pesquisar";
            // 
            // BotonPesquisarCliente
            // 
            this.BotonPesquisarCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonPesquisarCliente.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.BotonPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPesquisarCliente.Location = new System.Drawing.Point(669, 81);
            this.BotonPesquisarCliente.Name = "BotonPesquisarCliente";
            this.BotonPesquisarCliente.Size = new System.Drawing.Size(100, 33);
            this.BotonPesquisarCliente.TabIndex = 22;
            this.BotonPesquisarCliente.Text = "     Pesquisar";
            this.BotonPesquisarCliente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonPesquisarCliente.UseSelectable = true;
            this.BotonPesquisarCliente.Click += new System.EventHandler(this.BotonPesquisarUser_Click);
            // 
            // BotonGerar
            // 
            this.BotonGerar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonGerar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_impressão_32;
            this.BotonGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonGerar.Location = new System.Drawing.Point(167, 367);
            this.BotonGerar.Name = "BotonGerar";
            this.BotonGerar.Size = new System.Drawing.Size(112, 29);
            this.BotonGerar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonGerar.TabIndex = 20;
            this.BotonGerar.Text = "Gerar Arquivo";
            this.BotonGerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonGerar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonGerar.UseSelectable = true;
            this.BotonGerar.Click += new System.EventHandler(this.BotonGerar_Click);
            // 
            // BotonVoltar
            // 
            this.BotonVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_voltar_32;
            this.BotonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonVoltar.Location = new System.Drawing.Point(669, 367);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(100, 29);
            this.BotonVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonVoltar.TabIndex = 17;
            this.BotonVoltar.Text = "Voltar";
            this.BotonVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonVoltar.UseSelectable = true;
            this.BotonVoltar.Click += new System.EventHandler(this.BotonVoltar_Click);
            // 
            // gridTextForma
            // 
            // 
            // 
            // 
            this.gridTextForma.CustomButton.Image = null;
            this.gridTextForma.CustomButton.Location = new System.Drawing.Point(454, 1);
            this.gridTextForma.CustomButton.Name = "";
            this.gridTextForma.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.gridTextForma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gridTextForma.CustomButton.TabIndex = 1;
            this.gridTextForma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridTextForma.CustomButton.UseSelectable = true;
            this.gridTextForma.CustomButton.Visible = false;
            this.gridTextForma.DisplayIcon = true;
            this.gridTextForma.Icon = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_16;
            this.gridTextForma.Lines = new string[0];
            this.gridTextForma.Location = new System.Drawing.Point(140, 89);
            this.gridTextForma.MaxLength = 32767;
            this.gridTextForma.Name = "gridTextForma";
            this.gridTextForma.PasswordChar = '\0';
            this.gridTextForma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTextForma.SelectedText = "";
            this.gridTextForma.SelectionLength = 0;
            this.gridTextForma.SelectionStart = 0;
            this.gridTextForma.ShortcutsEnabled = true;
            this.gridTextForma.Size = new System.Drawing.Size(478, 25);
            this.gridTextForma.TabIndex = 16;
            this.gridTextForma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridTextForma.UseSelectable = true;
            this.gridTextForma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gridTextForma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(0, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormRelatorioFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.BotonPesquisarCliente);
            this.Controls.Add(this.cmdGerarArquivo);
            this.Controls.Add(this.BotonGerar);
            this.Controls.Add(this.GridFormaPagamento);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.gridTextForma);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioFormaPagamento";
            this.Resizable = false;
            this.Text = "Relatorio Forma de Pagamento";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormRelatorioFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BotonPesquisarCliente;
        private MetroFramework.Controls.MetroComboBox cmdGerarArquivo;
        private MetroFramework.Controls.MetroButton BotonGerar;
        private MetroFramework.Controls.MetroGrid GridFormaPagamento;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroButton BotonVoltar;
        private MetroFramework.Controls.MetroTextBox gridTextForma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}