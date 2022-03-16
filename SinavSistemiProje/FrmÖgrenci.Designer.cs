
namespace SinavSistemiProje
{
    partial class FrmÖgrenci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSifremiUnuttum);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.btnKayitOl);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(165, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 290);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(224, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "LÜTFEN GİRİŞ YAPINIZ";
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(311, 126);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(125, 30);
            this.btnSifremiUnuttum.TabIndex = 9;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // FrmÖgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "FrmÖgrenci";
            this.Text = "FrmÖgrenci";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifremiUnuttum;
    }
}