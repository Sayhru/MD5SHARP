namespace md5Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Criptografar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cripText = new System.Windows.Forms.RichTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.compareText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Criptografar
            // 
            this.Criptografar.AutoRoundedCorners = true;
            this.Criptografar.BorderRadius = 24;
            this.Criptografar.FillColor = System.Drawing.Color.SeaGreen;
            this.Criptografar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Criptografar.ForeColor = System.Drawing.Color.YellowGreen;
            this.Criptografar.Location = new System.Drawing.Point(414, 218);
            this.Criptografar.Name = "Criptografar";
            this.Criptografar.Size = new System.Drawing.Size(180, 51);
            this.Criptografar.TabIndex = 1;
            this.Criptografar.Text = "Criptografar";
            this.Criptografar.Click += new System.EventHandler(this.Criptografar_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cripText
            // 
            this.cripText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cripText.Location = new System.Drawing.Point(132, 48);
            this.cripText.Name = "cripText";
            this.cripText.Size = new System.Drawing.Size(695, 164);
            this.cripText.TabIndex = 3;
            this.cripText.Text = "";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 24;
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.guna2Button1.Location = new System.Drawing.Point(414, 488);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 51);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Comparar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // compareText
            // 
            this.compareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareText.Location = new System.Drawing.Point(132, 318);
            this.compareText.Name = "compareText";
            this.compareText.Size = new System.Drawing.Size(695, 164);
            this.compareText.TabIndex = 8;
            this.compareText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(987, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compareText);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cripText);
            this.Controls.Add(this.Criptografar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Criptografar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.RichTextBox cripText;
        private System.Windows.Forms.RichTextBox compareText;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}

