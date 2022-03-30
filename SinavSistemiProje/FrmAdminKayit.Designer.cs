
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminMail = new System.Windows.Forms.TextBox();
            this.txtAdminSurname = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnAdminKayitOl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "AdminKayıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "AdminSurname:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAnasayfa);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtAdminPassword);
            this.groupBox1.Controls.Add(this.txtAdminMail);
            this.groupBox1.Controls.Add(this.txtAdminSurname);
            this.groupBox1.Controls.Add(this.txtAdminName);
            this.groupBox1.Controls.Add(this.btnAdminKayitOl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(143, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 304);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AdminKayıt";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(411, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "AdminPassword:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "AdminMail:";
            // 
            // FrmAdminKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FrmAdminKayit";
            this.Text = "FrmAdminKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminMail;
        private System.Windows.Forms.TextBox txtAdminSurname;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnAdminKayitOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnAnasayfa;
    }
}