
namespace SinavSistemiProje
{
    partial class FrmÖğretmenKayit
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
            this.grbxOgretmenKayit = new System.Windows.Forms.GroupBox();
            this.chbxSifre = new System.Windows.Forms.CheckBox();
            this.txtTeacherTel = new System.Windows.Forms.TextBox();
            this.lblTeacherTel = new System.Windows.Forms.Label();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.txtTeacherMail = new System.Windows.Forms.TextBox();
            this.txtTeacherSurname = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnÖğretmenKayitOl = new System.Windows.Forms.Button();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.lblTeacherMail = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblOgretmenKayit = new System.Windows.Forms.Label();
            this.grbxOgretmenKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxOgretmenKayit
            // 
            this.grbxOgretmenKayit.Controls.Add(this.chbxSifre);
            this.grbxOgretmenKayit.Controls.Add(this.txtTeacherTel);
            this.grbxOgretmenKayit.Controls.Add(this.lblTeacherTel);
            this.grbxOgretmenKayit.Controls.Add(this.txtTeacherPassword);
            this.grbxOgretmenKayit.Controls.Add(this.txtTeacherMail);
            this.grbxOgretmenKayit.Controls.Add(this.txtTeacherSurname);
            this.grbxOgretmenKayit.Controls.Add(this.txtTeacherName);
            this.grbxOgretmenKayit.Controls.Add(this.btnÖğretmenKayitOl);
            this.grbxOgretmenKayit.Controls.Add(this.lblTeacherPassword);
            this.grbxOgretmenKayit.Controls.Add(this.lblTeacherMail);
            this.grbxOgretmenKayit.Controls.Add(this.lblTeacherName);
            this.grbxOgretmenKayit.Controls.Add(this.lblTeacherSurname);
            this.grbxOgretmenKayit.Location = new System.Drawing.Point(142, 91);
            this.grbxOgretmenKayit.Name = "grbxOgretmenKayit";
            this.grbxOgretmenKayit.Size = new System.Drawing.Size(536, 364);
            this.grbxOgretmenKayit.TabIndex = 7;
            this.grbxOgretmenKayit.TabStop = false;
            this.grbxOgretmenKayit.Text = "ÖğretmenKayıt";
            // 
            // chbxSifre
            // 
            this.chbxSifre.AutoSize = true;
            this.chbxSifre.Location = new System.Drawing.Point(411, 182);
            this.chbxSifre.Name = "chbxSifre";
            this.chbxSifre.Size = new System.Drawing.Size(73, 21);
            this.chbxSifre.TabIndex = 13;
            this.chbxSifre.Text = "Göster";
            this.chbxSifre.UseVisualStyleBackColor = true;
            this.chbxSifre.CheckedChanged += new System.EventHandler(this.chbxSifre_CheckedChanged);
            // 
            // txtTeacherTel
            // 
            this.txtTeacherTel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeacherTel.Location = new System.Drawing.Point(210, 218);
            this.txtTeacherTel.Name = "txtTeacherTel";
            this.txtTeacherTel.Size = new System.Drawing.Size(195, 30);
            this.txtTeacherTel.TabIndex = 11;
            this.txtTeacherTel.TextChanged += new System.EventHandler(this.txtTeacherTel_TextChanged);
            // 
            // lblTeacherTel
            // 
            this.lblTeacherTel.AutoSize = true;
            this.lblTeacherTel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeacherTel.Location = new System.Drawing.Point(6, 218);
            this.lblTeacherTel.Name = "lblTeacherTel";
            this.lblTeacherTel.Size = new System.Drawing.Size(105, 25);
            this.lblTeacherTel.TabIndex = 10;
            this.lblTeacherTel.Text = "TeacherTel:";
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeacherPassword.Location = new System.Drawing.Point(210, 173);
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.Size = new System.Drawing.Size(195, 30);
            this.txtTeacherPassword.TabIndex = 9;
            this.txtTeacherPassword.UseSystemPasswordChar = true;
            // 
            // txtTeacherMail
            // 
            this.txtTeacherMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeacherMail.Location = new System.Drawing.Point(210, 128);
            this.txtTeacherMail.Name = "txtTeacherMail";
            this.txtTeacherMail.Size = new System.Drawing.Size(195, 30);
            this.txtTeacherMail.TabIndex = 8;
            // 
            // txtTeacherSurname
            // 
            this.txtTeacherSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeacherSurname.Location = new System.Drawing.Point(210, 77);
            this.txtTeacherSurname.Name = "txtTeacherSurname";
            this.txtTeacherSurname.Size = new System.Drawing.Size(195, 30);
            this.txtTeacherSurname.TabIndex = 7;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeacherName.Location = new System.Drawing.Point(210, 28);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(195, 30);
            this.txtTeacherName.TabIndex = 6;
            // 
            // btnÖğretmenKayitOl
            // 
            this.btnÖğretmenKayitOl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖğretmenKayitOl.ForeColor = System.Drawing.Color.Olive;
            this.btnÖğretmenKayitOl.Location = new System.Drawing.Point(112, 276);
            this.btnÖğretmenKayitOl.Name = "btnÖğretmenKayitOl";
            this.btnÖğretmenKayitOl.Size = new System.Drawing.Size(121, 57);
            this.btnÖğretmenKayitOl.TabIndex = 5;
            this.btnÖğretmenKayitOl.Text = "Kayıt Ol";
            this.btnÖğretmenKayitOl.UseVisualStyleBackColor = true;
            this.btnÖğretmenKayitOl.Click += new System.EventHandler(this.btnÖğretmenKayitOl_Click);
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeacherPassword.Location = new System.Drawing.Point(6, 173);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(161, 25);
            this.lblTeacherPassword.TabIndex = 4;
            this.lblTeacherPassword.Text = "TeacherPassword:";
            // 
            // lblTeacherMail
            // 
            this.lblTeacherMail.AutoSize = true;
            this.lblTeacherMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeacherMail.Location = new System.Drawing.Point(6, 128);
            this.lblTeacherMail.Name = "lblTeacherMail";
            this.lblTeacherMail.Size = new System.Drawing.Size(120, 25);
            this.lblTeacherMail.TabIndex = 3;
            this.lblTeacherMail.Text = "TeacherMail:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeacherName.Location = new System.Drawing.Point(6, 28);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(134, 25);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "TeacherName:";
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeacherSurname.Location = new System.Drawing.Point(6, 82);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(158, 25);
            this.lblTeacherSurname.TabIndex = 2;
            this.lblTeacherSurname.Text = "TeacherSurname:";
            // 
            // lblOgretmenKayit
            // 
            this.lblOgretmenKayit.AutoSize = true;
            this.lblOgretmenKayit.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOgretmenKayit.Location = new System.Drawing.Point(242, -4);
            this.lblOgretmenKayit.Name = "lblOgretmenKayit";
            this.lblOgretmenKayit.Size = new System.Drawing.Size(322, 68);
            this.lblOgretmenKayit.TabIndex = 6;
            this.lblOgretmenKayit.Text = "ÖğretmenKayıt";
            // 
            // FrmÖğretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.grbxOgretmenKayit);
            this.Controls.Add(this.lblOgretmenKayit);
            this.Name = "FrmÖğretmenKayit";
            this.Text = "ÖğretmenKayit";
            this.grbxOgretmenKayit.ResumeLayout(false);
            this.grbxOgretmenKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxOgretmenKayit;
        private System.Windows.Forms.TextBox txtTeacherTel;
        private System.Windows.Forms.Label lblTeacherTel;
        private System.Windows.Forms.TextBox txtTeacherPassword;
        private System.Windows.Forms.TextBox txtTeacherMail;
        private System.Windows.Forms.TextBox txtTeacherSurname;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnÖğretmenKayitOl;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.Label lblTeacherMail;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherSurname;
        private System.Windows.Forms.Label lblOgretmenKayit;
        private System.Windows.Forms.CheckBox chbxSifre;
    }
}