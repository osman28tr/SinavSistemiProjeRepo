
namespace SinavSistemiProje
{
    partial class FrmÖgrenciAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavDurumumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxBilgilerim = new System.Windows.Forms.GroupBox();
            this.chbxSifre = new System.Windows.Forms.CheckBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnÖğrenciGüncelle = new System.Windows.Forms.Button();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblOgrenciIsim = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbxBilgilerim.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimToolStripMenuItem,
            this.sınavDurumumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.profilimToolStripMenuItem.Text = "Profilim";
            // 
            // sınavDurumumToolStripMenuItem
            // 
            this.sınavDurumumToolStripMenuItem.Name = "sınavDurumumToolStripMenuItem";
            this.sınavDurumumToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.sınavDurumumToolStripMenuItem.Text = "Sınav Durumum";
            this.sınavDurumumToolStripMenuItem.Click += new System.EventHandler(this.sınavDurumumToolStripMenuItem_Click);
            // 
            // grbxBilgilerim
            // 
            this.grbxBilgilerim.Controls.Add(this.chbxSifre);
            this.grbxBilgilerim.Controls.Add(this.txtStudentNo);
            this.grbxBilgilerim.Controls.Add(this.lblStudentNo);
            this.grbxBilgilerim.Controls.Add(this.txtStudentPassword);
            this.grbxBilgilerim.Controls.Add(this.txtStudentMail);
            this.grbxBilgilerim.Controls.Add(this.txtStudentSurname);
            this.grbxBilgilerim.Controls.Add(this.txtStudentName);
            this.grbxBilgilerim.Controls.Add(this.btnÖğrenciGüncelle);
            this.grbxBilgilerim.Controls.Add(this.lblStudentPassword);
            this.grbxBilgilerim.Controls.Add(this.lblStudentMail);
            this.grbxBilgilerim.Controls.Add(this.lblStudentName);
            this.grbxBilgilerim.Controls.Add(this.lblStudentSurname);
            this.grbxBilgilerim.Location = new System.Drawing.Point(126, 88);
            this.grbxBilgilerim.Name = "grbxBilgilerim";
            this.grbxBilgilerim.Size = new System.Drawing.Size(577, 329);
            this.grbxBilgilerim.TabIndex = 18;
            this.grbxBilgilerim.TabStop = false;
            this.grbxBilgilerim.Text = "Bilgilerim";
            // 
            // chbxSifre
            // 
            this.chbxSifre.AutoSize = true;
            this.chbxSifre.Location = new System.Drawing.Point(411, 172);
            this.chbxSifre.Name = "chbxSifre";
            this.chbxSifre.Size = new System.Drawing.Size(73, 21);
            this.chbxSifre.TabIndex = 23;
            this.chbxSifre.Text = "Göster";
            this.chbxSifre.UseVisualStyleBackColor = true;
            this.chbxSifre.CheckedChanged += new System.EventHandler(this.chbxSifre_CheckedChanged);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.Location = new System.Drawing.Point(210, 208);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(195, 30);
            this.txtStudentNo.TabIndex = 22;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentNo.Location = new System.Drawing.Point(6, 208);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(110, 25);
            this.lblStudentNo.TabIndex = 21;
            this.lblStudentNo.Text = "ÖğrenciNo:";
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentPassword.Location = new System.Drawing.Point(210, 163);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(195, 30);
            this.txtStudentPassword.TabIndex = 20;
            this.txtStudentPassword.UseSystemPasswordChar = true;
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentMail.Location = new System.Drawing.Point(210, 118);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(195, 30);
            this.txtStudentMail.TabIndex = 19;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentSurname.Location = new System.Drawing.Point(210, 67);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(195, 30);
            this.txtStudentSurname.TabIndex = 18;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentName.Location = new System.Drawing.Point(210, 18);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(195, 30);
            this.txtStudentName.TabIndex = 17;
            // 
            // btnÖğrenciGüncelle
            // 
            this.btnÖğrenciGüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖğrenciGüncelle.ForeColor = System.Drawing.Color.Olive;
            this.btnÖğrenciGüncelle.Location = new System.Drawing.Point(210, 284);
            this.btnÖğrenciGüncelle.Name = "btnÖğrenciGüncelle";
            this.btnÖğrenciGüncelle.Size = new System.Drawing.Size(121, 39);
            this.btnÖğrenciGüncelle.TabIndex = 16;
            this.btnÖğrenciGüncelle.Text = "Güncelle";
            this.btnÖğrenciGüncelle.UseVisualStyleBackColor = true;
            this.btnÖğrenciGüncelle.Click += new System.EventHandler(this.btnÖğrenciGüncelle_Click);
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentPassword.Location = new System.Drawing.Point(6, 163);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(163, 25);
            this.lblStudentPassword.TabIndex = 15;
            this.lblStudentPassword.Text = "ÖğrenciPassword:";
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentMail.Location = new System.Drawing.Point(6, 118);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(122, 25);
            this.lblStudentMail.TabIndex = 14;
            this.lblStudentMail.Text = "ÖğrenciMail:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentName.Location = new System.Drawing.Point(6, 18);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(136, 25);
            this.lblStudentName.TabIndex = 12;
            this.lblStudentName.Text = "ÖğrenciName:";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentSurname.Location = new System.Drawing.Point(6, 72);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(160, 25);
            this.lblStudentSurname.TabIndex = 13;
            this.lblStudentSurname.Text = "ÖğrenciSurname:";
            // 
            // lblOgrenciIsim
            // 
            this.lblOgrenciIsim.AutoSize = true;
            this.lblOgrenciIsim.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciIsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOgrenciIsim.Location = new System.Drawing.Point(285, 40);
            this.lblOgrenciIsim.Name = "lblOgrenciIsim";
            this.lblOgrenciIsim.Size = new System.Drawing.Size(266, 54);
            this.lblOgrenciIsim.TabIndex = 17;
            this.lblOgrenciIsim.Text = "HOŞ GELDİNİZ ";
            // 
            // FrmÖgrenciAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(928, 513);
            this.Controls.Add(this.grbxBilgilerim);
            this.Controls.Add(this.lblOgrenciIsim);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmÖgrenciAnaSayfa";
            this.Text = "OgrenciAnaSayfa";
            this.Load += new System.EventHandler(this.FrmÖgrenciAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbxBilgilerim.ResumeLayout(false);
            this.grbxBilgilerim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavDurumumToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbxBilgilerim;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnÖğrenciGüncelle;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblOgrenciIsim;
        private System.Windows.Forms.CheckBox chbxSifre;
    }
}