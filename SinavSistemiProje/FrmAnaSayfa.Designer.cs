
namespace SinavSistemiProje
{
    partial class FrmAnaSayfa
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
            this.grbxKullaniciTur = new System.Windows.Forms.GroupBox();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxKullaniciTur.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxKullaniciTur
            // 
            this.grbxKullaniciTur.Controls.Add(this.btnOgretmen);
            this.grbxKullaniciTur.Controls.Add(this.btnOgrenci);
            this.grbxKullaniciTur.Controls.Add(this.BtnAdmin);
            this.grbxKullaniciTur.ForeColor = System.Drawing.Color.White;
            this.grbxKullaniciTur.Location = new System.Drawing.Point(188, 129);
            this.grbxKullaniciTur.Name = "grbxKullaniciTur";
            this.grbxKullaniciTur.Size = new System.Drawing.Size(427, 252);
            this.grbxKullaniciTur.TabIndex = 0;
            this.grbxKullaniciTur.TabStop = false;
            this.grbxKullaniciTur.Text = "Kullanıcı Türleri";
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOgretmen.Location = new System.Drawing.Point(280, 30);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(141, 82);
            this.btnOgretmen.TabIndex = 2;
            this.btnOgretmen.Text = "Öğretmen";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOgrenci.Location = new System.Drawing.Point(151, 127);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(141, 82);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAdmin.Location = new System.Drawing.Point(16, 30);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(141, 82);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞ GELDİNİZ ";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(756, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbxKullaniciTur);
            this.Name = "FrmAnaSayfa";
            this.Text = "AnaSayfa";
            this.grbxKullaniciTur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxKullaniciTur;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Label label1;
    }
}

