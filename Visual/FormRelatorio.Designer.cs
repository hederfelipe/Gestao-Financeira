namespace GestaoFinanceira.Visual
{
    partial class FormRelatorio
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Buton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.BotonCliente = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.AllowDrop = true;
            this.metroButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton1.BackgroundImage = global::GestaoFinanceira.Properties.Resources.relatorio_vendas;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.metroButton1.Location = new System.Drawing.Point(243, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 92);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Pagamento";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.UseWaitCursor = true;
            this.metroButton1.Click += new System.EventHandler(this.BotonFormaPagamento_Click);
            // 
            // Buton
            // 
            this.Buton.AllowDrop = true;
            this.Buton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buton.BackgroundImage = global::GestaoFinanceira.Properties.Resources.unnamed2;
            this.Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Buton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Buton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Buton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Buton.Location = new System.Drawing.Point(23, 63);
            this.Buton.Name = "Buton";
            this.Buton.Size = new System.Drawing.Size(104, 92);
            this.Buton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Buton.TabIndex = 1;
            this.Buton.Text = "Usuário";
            this.Buton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Buton.UseSelectable = true;
            this.Buton.UseStyleColors = true;
            this.Buton.Click += new System.EventHandler(this.BotonRelatorioUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.f48e4be45031c0afd0c987398ffc9e35;
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Black;
            this.metroButton3.BackgroundImage = global::GestaoFinanceira.Properties.Resources.kisspng_computer_icons_button_power_symbol_clip_art_20_off_5b43e887b802c1_4079305915311770957537;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton3.Location = new System.Drawing.Point(683, 308);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(85, 119);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Retornar";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // BotonCliente
            // 
            this.BotonCliente.BackColor = System.Drawing.Color.Black;
            this.BotonCliente.BackgroundImage = global::GestaoFinanceira.Properties.Resources.paciente_cadastro;
            this.BotonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCliente.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BotonCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCliente.Location = new System.Drawing.Point(133, 63);
            this.BotonCliente.Name = "BotonCliente";
            this.BotonCliente.Size = new System.Drawing.Size(104, 92);
            this.BotonCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotonCliente.TabIndex = 7;
            this.BotonCliente.Text = "Cliente";
            this.BotonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotonCliente.UseSelectable = true;
            this.BotonCliente.UseStyleColors = true;
            this.BotonCliente.Click += new System.EventHandler(this.BotonRelatorioCliente_Click);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonCliente);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Buton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorio";
            this.Resizable = false;
            this.Text = "Relatorio";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Buton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton BotonCliente;
    }
}