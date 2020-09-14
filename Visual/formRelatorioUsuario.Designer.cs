namespace GestaoFinanceira.Visual
{
    partial class formRelatorioUsuario
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
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.GridUsuario = new MetroFramework.Controls.MetroGrid();
            this.cmdGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            this.BotonPesquisarUser = new MetroFramework.Controls.MetroButton();
            this.BotonGerar = new MetroFramework.Controls.MetroButton();
            this.BotonVoltar = new MetroFramework.Controls.MetroButton();
            this.gridText = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel.Location = new System.Drawing.Point(50, 82);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(83, 25);
            this.metroLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel.TabIndex = 10;
            this.metroLabel.Text = "Pesquisar";
            // 
            // GridUsuario
            // 
            this.GridUsuario.AllowUserToAddRows = false;
            this.GridUsuario.AllowUserToDeleteRows = false;
            this.GridUsuario.AllowUserToResizeRows = false;
            this.GridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.GridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridUsuario.EnableHeadersVisualStyles = false;
            this.GridUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridUsuario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridUsuario.Location = new System.Drawing.Point(50, 113);
            this.GridUsuario.Name = "GridUsuario";
            this.GridUsuario.ReadOnly = true;
            this.GridUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsuario.RowHeadersVisible = false;
            this.GridUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuario.Size = new System.Drawing.Size(718, 241);
            this.GridUsuario.Style = MetroFramework.MetroColorStyle.Silver;
            this.GridUsuario.TabIndex = 12;
            this.GridUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GridUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuario_CellDoubleClick);
            // 
            // cmdGerarArquivo
            // 
            this.cmdGerarArquivo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdGerarArquivo.FormattingEnabled = true;
            this.cmdGerarArquivo.ItemHeight = 23;
            this.cmdGerarArquivo.Location = new System.Drawing.Point(50, 360);
            this.cmdGerarArquivo.Name = "cmdGerarArquivo";
            this.cmdGerarArquivo.Size = new System.Drawing.Size(100, 29);
            this.cmdGerarArquivo.TabIndex = 14;
            this.cmdGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdGerarArquivo.UseSelectable = true;
            // 
            // BotonPesquisarUser
            // 
            this.BotonPesquisarUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonPesquisarUser.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.BotonPesquisarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPesquisarUser.Location = new System.Drawing.Point(668, 74);
            this.BotonPesquisarUser.Name = "BotonPesquisarUser";
            this.BotonPesquisarUser.Size = new System.Drawing.Size(100, 33);
            this.BotonPesquisarUser.TabIndex = 15;
            this.BotonPesquisarUser.Text = "     Pesquisar";
            this.BotonPesquisarUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonPesquisarUser.UseSelectable = true;
            this.BotonPesquisarUser.Click += new System.EventHandler(this.BotonPesquisarUser_Click);
            // 
            // BotonGerar
            // 
            this.BotonGerar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonGerar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_impressão_32;
            this.BotonGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonGerar.Location = new System.Drawing.Point(166, 360);
            this.BotonGerar.Name = "BotonGerar";
            this.BotonGerar.Size = new System.Drawing.Size(112, 29);
            this.BotonGerar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonGerar.TabIndex = 13;
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
            this.BotonVoltar.Location = new System.Drawing.Point(668, 360);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(100, 29);
            this.BotonVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonVoltar.TabIndex = 9;
            this.BotonVoltar.Text = "Voltar";
            this.BotonVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BotonVoltar.UseSelectable = true;
            this.BotonVoltar.Click += new System.EventHandler(this.BotonVoltar_Click);
            // 
            // gridText
            // 
            // 
            // 
            // 
            this.gridText.CustomButton.Image = null;
            this.gridText.CustomButton.Location = new System.Drawing.Point(454, 1);
            this.gridText.CustomButton.Name = "";
            this.gridText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.gridText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gridText.CustomButton.TabIndex = 1;
            this.gridText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridText.CustomButton.UseSelectable = true;
            this.gridText.CustomButton.Visible = false;
            this.gridText.DisplayIcon = true;
            this.gridText.Icon = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_16;
            this.gridText.Lines = new string[0];
            this.gridText.Location = new System.Drawing.Point(139, 82);
            this.gridText.MaxLength = 32767;
            this.gridText.Name = "gridText";
            this.gridText.PasswordChar = '\0';
            this.gridText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridText.SelectedText = "";
            this.gridText.SelectionLength = 0;
            this.gridText.SelectionStart = 0;
            this.gridText.ShortcutsEnabled = true;
            this.gridText.Size = new System.Drawing.Size(478, 25);
            this.gridText.TabIndex = 4;
            this.gridText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridText.UseSelectable = true;
            this.gridText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gridText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // formRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.BotonPesquisarUser);
            this.Controls.Add(this.cmdGerarArquivo);
            this.Controls.Add(this.BotonGerar);
            this.Controls.Add(this.GridUsuario);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.gridText);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "formRelatorioUsuario";
            this.Resizable = false;
            this.Text = "Formulario de Usuário";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FromRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox gridText;
        private MetroFramework.Controls.MetroButton BotonVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroGrid GridUsuario;
        private MetroFramework.Controls.MetroButton BotonGerar;
        private MetroFramework.Controls.MetroComboBox cmdGerarArquivo;
        private MetroFramework.Controls.MetroButton BotonPesquisarUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}