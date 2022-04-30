
namespace SinavSistemiProje
{
    partial class FrmAdminKayit
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdminKayit = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grbxAdminKayit = new System.Windows.Forms.GroupBox();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.chbxSifre = new System.Windows.Forms.CheckBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminMail = new System.Windows.Forms.TextBox();
            this.txtAdminSurname = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnAdminKayitOl = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.grbxAdminKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "AdminName:";
            // 
            // lblAdminKayit
            // 
            this.lblAdminKayit.AutoSize = true;
            this.lblAdminKayit.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAdminKayit.Location = new System.Drawing.Point(243, 9);
            this.lblAdminKayit.Name = "lblAdminKayit";
            this.lblAdminKayit.Size = new System.Drawing.Size(258, 68);
            this.lblAdminKayit.TabIndex = 1;
            this.lblAdminKayit.Text = "AdminKayıt";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.ForeColor = System.Drawing.Color.Green;
            this.lblSurname.Location = new System.Drawing.Point(6, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(150, 25);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "AdminSurname:";
            // 
            // grbxAdminKayit
            // 
            this.grbxAdminKayit.Controls.Add(this.BtnAnasayfa);
            this.grbxAdminKayit.Controls.Add(this.chbxSifre);
            this.grbxAdminKayit.Controls.Add(this.txtAdminPassword);
            this.grbxAdminKayit.Controls.Add(this.txtAdminMail);
            this.grbxAdminKayit.Controls.Add(this.txtAdminSurname);
            this.grbxAdminKayit.Controls.Add(this.txtAdminName);
            this.grbxAdminKayit.Controls.Add(this.btnAdminKayitOl);
            this.grbxAdminKayit.Controls.Add(this.lblPassword);
            this.grbxAdminKayit.Controls.Add(this.lblMail);
            this.grbxAdminKayit.Controls.Add(this.lblName);
            this.grbxAdminKayit.Controls.Add(this.lblSurname);
            this.grbxAdminKayit.Location = new System.Drawing.Point(143, 104);
            this.grbxAdminKayit.Name = "grbxAdminKayit";
            this.grbxAdminKayit.Size = new System.Drawing.Size(537, 304);
            this.grbxAdminKayit.TabIndex = 3;
            this.grbxAdminKayit.TabStop = false;
            this.grbxAdminKayit.Text = "AdminKayıt";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnasayfa.ForeColor = System.Drawing.Color.Olive;
            this.BtnAnasayfa.Location = new System.Drawing.Point(284, 230);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(200, 57);
            this.BtnAnasayfa.TabIndex = 11;
            this.BtnAnasayfa.Text = "←AnaSayfayaDon";
            this.BtnAnasayfa.UseVisualStyleBackColor = true;
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // chbxSifre
            // 
            this.chbxSifre.AutoSize = true;
            this.chbxSifre.Location = new System.Drawing.Point(411, 180);
            this.chbxSifre.Name = "chbxSifre";
            this.chbxSifre.Size = new System.Drawing.Size(73, 21);
            this.chbxSifre.TabIndex = 10;
            this.chbxSifre.Text = "Göster";
            this.chbxSifre.UseVisualStyleBackColor = true;
            this.chbxSifre.CheckedChanged += new System.EventHandler(this.chbxSifre_CheckedChanged);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminPassword.Location = new System.Drawing.Point(210, 173);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(195, 30);
            this.txtAdminPassword.TabIndex = 9;
            this.txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // txtAdminMail
            // 
            this.txtAdminMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdminMail.Location = new System.Drawing.Point(210, 128);
            this.txtAdminMail.Name = "txtAdminMail";
            this.txtAdminMail.Size = new System.Drawing.Size(195, 30);
            this.txtAdminMail.TabIndex = 8;
            // 
            // txtAdminSurname
            // 
            this.txtAdminSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdminSurname.Location = new System.Drawing.Point(210, 77);
            this.txtAdminSurname.Name = "txtAdminSurname";
            this.txtAdminSurname.Size = new System.Drawing.Size(195, 30);
            this.txtAdminSurname.TabIndex = 7;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdminName.Location = new System.Drawing.Point(210, 28);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(195, 30);
            this.txtAdminName.TabIndex = 6;
            // 
            // btnAdminKayitOl
            // 
            this.btnAdminKayitOl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminKayitOl.ForeColor = System.Drawing.Color.Olive;
            this.btnAdminKayitOl.Location = new System.Drawing.Point(35, 230);
            this.btnAdminKayitOl.Name = "btnAdminKayitOl";
            this.btnAdminKayitOl.Size = new System.Drawing.Size(198, 57);
            this.btnAdminKayitOl.TabIndex = 5;
            this.btnAdminKayitOl.Text = "Kayıt Ol";
            this.btnAdminKayitOl.UseVisualStyleBackColor = true;
            this.btnAdminKayitOl.Click += new System.EventHandler(this.btnAdminKayitOl_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Green;
            this.lblPassword.Location = new System.Drawing.Point(6, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(153, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "AdminPassword:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Green;
            this.lblMail.Location = new System.Drawing.Point(6, 128);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(112, 25);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "AdminMail:";
            // 
            // FrmAdminKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbxAdminKayit);
            this.Controls.Add(this.lblAdminKayit);
            this.Name = "FrmAdminKayit";
            this.Text = "AdminKayit";
            this.grbxAdminKayit.ResumeLayout(false);
            this.grbxAdminKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdminKayit;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grbxAdminKayit;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminMail;
        private System.Windows.Forms.TextBox txtAdminSurname;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnAdminKayitOl;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.CheckBox chbxSifre;
        private System.Windows.Forms.Button BtnAnasayfa;
    }
}