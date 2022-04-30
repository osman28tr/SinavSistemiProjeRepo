
namespace SinavSistemiProje
{
    partial class FrmÖğretmen
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
            this.grbxOgretmen = new System.Windows.Forms.GroupBox();
            this.chbxSifre = new System.Windows.Forms.CheckBox();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.grbxOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxOgretmen
            // 
            this.grbxOgretmen.Controls.Add(this.chbxSifre);
            this.grbxOgretmen.Controls.Add(this.btnSifremiUnuttum);
            this.grbxOgretmen.Controls.Add(this.txtMail);
            this.grbxOgretmen.Controls.Add(this.btnKayitOl);
            this.grbxOgretmen.Controls.Add(this.txtSifre);
            this.grbxOgretmen.Controls.Add(this.btnGiris);
            this.grbxOgretmen.Controls.Add(this.lblMail);
            this.grbxOgretmen.Controls.Add(this.lblSifre);
            this.grbxOgretmen.Location = new System.Drawing.Point(151, 115);
            this.grbxOgretmen.Name = "grbxOgretmen";
            this.grbxOgretmen.Size = new System.Drawing.Size(474, 290);
            this.grbxOgretmen.TabIndex = 11;
            this.grbxOgretmen.TabStop = false;
            this.grbxOgretmen.Text = "Öğretmen";
            // 
            // chbxSifre
            // 
            this.chbxSifre.AutoSize = true;
            this.chbxSifre.Location = new System.Drawing.Point(349, 75);
            this.chbxSifre.Name = "chbxSifre";
            this.chbxSifre.Size = new System.Drawing.Size(73, 21);
            this.chbxSifre.TabIndex = 12;
            this.chbxSifre.Text = "Göster";
            this.chbxSifre.UseVisualStyleBackColor = true;
            this.chbxSifre.CheckedChanged += new System.EventHandler(this.chbxSifre_CheckedChanged);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(311, 126);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(125, 30);
            this.btnSifremiUnuttum.TabIndex = 10;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(158, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 30);
            this.txtMail.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(329, 219);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(107, 50);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(158, 66);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(185, 30);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(101, 116);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(107, 50);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMail.Location = new System.Drawing.Point(25, 22);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(55, 28);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSifre.Location = new System.Drawing.Point(25, 68);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 28);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGiris.Location = new System.Drawing.Point(210, 37);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(383, 54);
            this.lblGiris.TabIndex = 10;
            this.lblGiris.Text = "LÜTFEN GİRİŞ YAPINIZ";
            // 
            // FrmÖğretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbxOgretmen);
            this.Controls.Add(this.lblGiris);
            this.Name = "FrmÖğretmen";
            this.Text = "Öğretmen";
            this.grbxOgretmen.ResumeLayout(false);
            this.grbxOgretmen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxOgretmen;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.CheckBox chbxSifre;
    }
}