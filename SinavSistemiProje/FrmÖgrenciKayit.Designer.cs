
namespace SinavSistemiProje
{
    partial class FrmÖgrenciKayit
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
            this.grbxOgrenciKayit = new System.Windows.Forms.GroupBox();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            this.chbxSifre = new System.Windows.Forms.CheckBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnÖğrenciKayitOl = new System.Windows.Forms.Button();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblOgrenciKayit = new System.Windows.Forms.Label();
            this.grbxOgrenciKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxOgrenciKayit
            // 
            this.grbxOgrenciKayit.Controls.Add(this.BtnAnaSayfa);
            this.grbxOgrenciKayit.Controls.Add(this.chbxSifre);
            this.grbxOgrenciKayit.Controls.Add(this.txtStudentNo);
            this.grbxOgrenciKayit.Controls.Add(this.lblStudentNo);
            this.grbxOgrenciKayit.Controls.Add(this.txtStudentPassword);
            this.grbxOgrenciKayit.Controls.Add(this.txtStudentMail);
            this.grbxOgrenciKayit.Controls.Add(this.txtStudentSurname);
            this.grbxOgrenciKayit.Controls.Add(this.txtStudentName);
            this.grbxOgrenciKayit.Controls.Add(this.btnÖğrenciKayitOl);
            this.grbxOgrenciKayit.Controls.Add(this.lblStudentPassword);
            this.grbxOgrenciKayit.Controls.Add(this.lblStudentMail);
            this.grbxOgrenciKayit.Controls.Add(this.lblStudentName);
            this.grbxOgrenciKayit.Controls.Add(this.lblStudentSurname);
            this.grbxOgrenciKayit.Location = new System.Drawing.Point(152, 117);
            this.grbxOgrenciKayit.Name = "grbxOgrenciKayit";
            this.grbxOgrenciKayit.Size = new System.Drawing.Size(534, 364);
            this.grbxOgrenciKayit.TabIndex = 5;
            this.grbxOgrenciKayit.TabStop = false;
            this.grbxOgrenciKayit.Text = "ÖğrenciKayıt";
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.ForeColor = System.Drawing.Color.Olive;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(300, 276);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(184, 57);
            this.BtnAnaSayfa.TabIndex = 13;
            this.BtnAnaSayfa.Text = "←AnaSayfayaDon";
            this.BtnAnaSayfa.UseVisualStyleBackColor = true;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // chbxSifre
            // 
            this.chbxSifre.AutoSize = true;
            this.chbxSifre.Location = new System.Drawing.Point(438, 182);
            this.chbxSifre.Name = "chbxSifre";
            this.chbxSifre.Size = new System.Drawing.Size(73, 21);
            this.chbxSifre.TabIndex = 12;
            this.chbxSifre.Text = "Göster";
            this.chbxSifre.UseVisualStyleBackColor = true;
            this.chbxSifre.CheckedChanged += new System.EventHandler(this.chbxSifre_CheckedChanged);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentNo.Location = new System.Drawing.Point(210, 218);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(221, 30);
            this.txtStudentNo.TabIndex = 11;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentNo.Location = new System.Drawing.Point(6, 218);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(110, 25);
            this.lblStudentNo.TabIndex = 10;
            this.lblStudentNo.Text = "ÖğrenciNo:";
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentPassword.Location = new System.Drawing.Point(210, 173);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(221, 30);
            this.txtStudentPassword.TabIndex = 9;
            this.txtStudentPassword.UseSystemPasswordChar = true;
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentMail.Location = new System.Drawing.Point(210, 128);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(221, 30);
            this.txtStudentMail.TabIndex = 8;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentSurname.Location = new System.Drawing.Point(210, 77);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(221, 30);
            this.txtStudentSurname.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentName.Location = new System.Drawing.Point(210, 28);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(221, 30);
            this.txtStudentName.TabIndex = 6;
            // 
            // btnÖğrenciKayitOl
            // 
            this.btnÖğrenciKayitOl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖğrenciKayitOl.ForeColor = System.Drawing.Color.Olive;
            this.btnÖğrenciKayitOl.Location = new System.Drawing.Point(50, 276);
            this.btnÖğrenciKayitOl.Name = "btnÖğrenciKayitOl";
            this.btnÖğrenciKayitOl.Size = new System.Drawing.Size(183, 57);
            this.btnÖğrenciKayitOl.TabIndex = 5;
            this.btnÖğrenciKayitOl.Text = "Kayıt Ol";
            this.btnÖğrenciKayitOl.UseVisualStyleBackColor = true;
            this.btnÖğrenciKayitOl.Click += new System.EventHandler(this.btnÖğrenciKayitOl_Click);
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentPassword.Location = new System.Drawing.Point(6, 173);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(163, 25);
            this.lblStudentPassword.TabIndex = 4;
            this.lblStudentPassword.Text = "ÖğrenciPassword:";
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentMail.Location = new System.Drawing.Point(6, 128);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(122, 25);
            this.lblStudentMail.TabIndex = 3;
            this.lblStudentMail.Text = "ÖğrenciMail:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentName.Location = new System.Drawing.Point(6, 28);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(136, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "ÖğrenciName:";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentSurname.Location = new System.Drawing.Point(6, 82);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(160, 25);
            this.lblStudentSurname.TabIndex = 2;
            this.lblStudentSurname.Text = "ÖğrenciSurname:";
            // 
            // lblOgrenciKayit
            // 
            this.lblOgrenciKayit.AutoSize = true;
            this.lblOgrenciKayit.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOgrenciKayit.Location = new System.Drawing.Point(252, 22);
            this.lblOgrenciKayit.Name = "lblOgrenciKayit";
            this.lblOgrenciKayit.Size = new System.Drawing.Size(276, 68);
            this.lblOgrenciKayit.TabIndex = 4;
            this.lblOgrenciKayit.Text = "ÖğrenciKayıt";
            // 
            // FrmÖgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.grbxOgrenciKayit);
            this.Controls.Add(this.lblOgrenciKayit);
            this.Name = "FrmÖgrenciKayit";
            this.Text = "ÖgrenciKayit";
            this.grbxOgrenciKayit.ResumeLayout(false);
            this.grbxOgrenciKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxOgrenciKayit;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnÖğrenciKayitOl;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblOgrenciKayit;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.CheckBox chbxSifre;
        private System.Windows.Forms.Button BtnAnaSayfa;
    }
}