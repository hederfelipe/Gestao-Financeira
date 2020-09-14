namespace GestaoFinanceira.Visual
{
    partial class FormRelatorio_Cliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonPesquisarCliente = new MetroFramework.Controls.MetroButton();
            this.cmdGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            this.BotonGerar = new MetroFramework.Controls.MetroButton();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.BotonVoltar = new MetroFramework.Controls.MetroButton();
            this.gridTextForma = new MetroFramework.Controls.MetroTextBox();
            this.GridCliente = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BotonPesquisarCliente
            // 
            this.BotonPesquisarCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonPesquisarCliente.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.BotonPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPesquisarCliente.Location = new System.Drawing.Point(651, 93);
            this.BotonPesquisarCliente.Name = "BotonPesquisarCliente";
            this.BotonPesquisarCliente.Size = new System.Drawing.Size(100, 33);
            this.BotonPesquisarCliente.TabIndex = 29;
            this.BotonPesquisarCliente.Text = "     Pesquisar";
            this.BotonPesquisarCliente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonPesquisarCliente.UseSelectable = true;
            this.BotonPesquisarCliente.Click += new System.EventHandler(this.BotonPesquisarCliente_Click);
            // 
            // cmdGerarArquivo
            // 
            this.cmdGerarArquivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGerarArquivo.FormattingEnabled = true;
            this.cmdGerarArquivo.ItemHeight = 23;
            this.cmdGerarArquivo.Location = new System.Drawing.Point(33, 379);
            this.cmdGerarArquivo.Name = "cmdGerarArquivo";
            this.cmdGerarArquivo.Size = new System.Drawing.Size(100, 29);
            this.cmdGerarArquivo.TabIndex = 28;
            this.cmdGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdGerarArquivo.UseSelectable = true;
            // 
            // BotonGerar
            // 
            this.BotonGerar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonGerar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_impressão_32;
            this.BotonGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonGerar.Location = new System.Drawing.Point(149, 379);
            this.BotonGerar.Name = "BotonGerar";
            this.BotonGerar.Size = new System.Drawing.Size(112, 29);
            this.BotonGerar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonGerar.TabIndex = 27;
            this.BotonGerar.Text = "Gerar Arquivo";
            this.BotonGerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonGerar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonGerar.UseSelectable = true;
            this.BotonGerar.Click += new System.EventHandler(this.BotonGerar_Click);
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel.Location = new System.Drawing.Point(33, 101);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(83, 25);
            this.metroLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel.TabIndex = 25;
            this.metroLabel.Text = "Pesquisar";
            // 
            // BotonVoltar
            // 
            this.BotonVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_voltar_32;
            this.BotonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonVoltar.Location = new System.Drawing.Point(651, 379);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(100, 29);
            this.BotonVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonVoltar.TabIndex = 24;
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
            this.gridTextForma.Location = new System.Drawing.Point(122, 101);
            this.gridTextForma.MaxLength = 32767;
            this.gridTextForma.Name = "gridTextForma";
            this.gridTextForma.PasswordChar = '\0';
            this.gridTextForma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTextForma.SelectedText = "";
            this.gridTextForma.SelectionLength = 0;
            this.gridTextForma.SelectionStart = 0;
            this.gridTextForma.ShortcutsEnabled = true;
            this.gridTextForma.Size = new System.Drawing.Size(478, 25);
            this.gridTextForma.TabIndex = 23;
            this.gridTextForma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridTextForma.UseSelectable = true;
            this.gridTextForma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gridTextForma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToAddRows = false;
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AllowUserToResizeRows = false;
            this.GridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridCliente.EnableHeadersVisualStyles = false;
            this.GridCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridCliente.Location = new System.Drawing.Point(33, 132);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridCliente.RowHeadersVisible = false;
            this.GridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCliente.Size = new System.Drawing.Size(718, 241);
            this.GridCliente.Style = MetroFramework.MetroColorStyle.Silver;
            this.GridCliente.TabIndex = 30;
            this.GridCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellDoubleClick);
            // 
            // FormRelatorio_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.GridCliente);
            this.Controls.Add(this.BotonPesquisarCliente);
            this.Controls.Add(this.cmdGerarArquivo);
            this.Controls.Add(this.BotonGerar);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.gridTextForma);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorio_Cliente";
            this.Resizable = false;
            this.Text = "Relatorio de Cliente";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormRelatorio_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BotonPesquisarCliente;
        private MetroFramework.Controls.MetroComboBox cmdGerarArquivo;
        private MetroFramework.Controls.MetroButton BotonGerar;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroButton BotonVoltar;
        private MetroFramework.Controls.MetroTextBox gridTextForma;
        private MetroFramework.Controls.MetroGrid GridCliente;
    }
}