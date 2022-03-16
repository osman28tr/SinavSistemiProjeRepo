
namespace SinavSistemiProje
{
    partial class FrmSifremiUnuttumAdmin
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
            this.txtAdminMail = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnSifremiGöster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdminMail);
            this.groupBox1.Controls.Add(this.txtAdminName);
            this.groupBox1.Controls.Add(this.btnSifremiGöster);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(138, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifremi Unuttum";
            // 
            // txtAdminMail
            // 
            this.txtAdminMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminMail.Location = new System.Drawing.Point(210, 110);
            this.txtAdminMail.Name = "txtAdminMail";
            this.txtAdminMail.Size = new System.Drawing.Size(195, 30);
            this.txtAdminMail.TabIndex = 8;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminName.Location = new System.Drawing.Point(210, 28);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(195, 30);
            this.txtAdminName.TabIndex = 6;
            // 
            // btnSifremiGöster
            // 
            this.btnSifremiGöster.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifremiGöster.ForeColor = System.Drawing.Color.Olive;
            this.btnSifremiGöster.Location = new System.Drawing.Point(124, 175);
            this.btnSifremiGöster.Name = "btnSifremiGöster";
            this.btnSifremiGöster.Size = new System.Drawing.Size(148, 57);
            this.btnSifremiGöster.TabIndex = 5;
            this.btnSifremiGöster.Text = "ŞifremiGöster";
            this.btnSifremiGöster.UseVisualStyleBackColor = true;
            this.btnSifremiGöster.Click += new System.EventHandler(this.btnSifremiGöster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "AdminMail:";
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
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lütfen Bilgileri Doldurunuz";
            // 
            // FrmSifremiUnuttumAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FrmSifremiUnuttumAdmin";
            this.Text = "FrmSifremiUnuttumAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminMail;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnSifremiGöster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}