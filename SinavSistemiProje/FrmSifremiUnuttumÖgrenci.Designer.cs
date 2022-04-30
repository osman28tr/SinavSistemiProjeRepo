
namespace SinavSistemiProje
{
    partial class FrmSifremiUnuttumÖgrenci
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
            this.grbxSifremiUnuttum = new System.Windows.Forms.GroupBox();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSifremiGöster = new System.Windows.Forms.Button();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblBilgiDoldur = new System.Windows.Forms.Label();
            this.grbxSifremiUnuttum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxSifremiUnuttum
            // 
            this.grbxSifremiUnuttum.Controls.Add(this.txtStudentMail);
            this.grbxSifremiUnuttum.Controls.Add(this.txtStudentName);
            this.grbxSifremiUnuttum.Controls.Add(this.btnSifremiGöster);
            this.grbxSifremiUnuttum.Controls.Add(this.lblStudentMail);
            this.grbxSifremiUnuttum.Controls.Add(this.lblStudentName);
            this.grbxSifremiUnuttum.Location = new System.Drawing.Point(132, 123);
            this.grbxSifremiUnuttum.Name = "grbxSifremiUnuttum";
            this.grbxSifremiUnuttum.Size = new System.Drawing.Size(516, 265);
            this.grbxSifremiUnuttum.TabIndex = 7;
            this.grbxSifremiUnuttum.TabStop = false;
            this.grbxSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentMail.Location = new System.Drawing.Point(210, 110);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(195, 30);
            this.txtStudentMail.TabIndex = 8;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentName.Location = new System.Drawing.Point(210, 28);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(195, 30);
            this.txtStudentName.TabIndex = 6;
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
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.Green;
            this.lblStudentMail.Location = new System.Drawing.Point(6, 110);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(121, 25);
            this.lblStudentMail.TabIndex = 3;
            this.lblStudentMail.Text = "StudentMail:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Green;
            this.lblStudentName.Location = new System.Drawing.Point(6, 28);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(135, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "StudentName:";
            // 
            // lblBilgiDoldur
            // 
            this.lblBilgiDoldur.AutoSize = true;
            this.lblBilgiDoldur.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiDoldur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBilgiDoldur.Location = new System.Drawing.Point(120, 32);
            this.lblBilgiDoldur.Name = "lblBilgiDoldur";
            this.lblBilgiDoldur.Size = new System.Drawing.Size(546, 68);
            this.lblBilgiDoldur.TabIndex = 6;
            this.lblBilgiDoldur.Text = "Lütfen Bilgileri Doldurunuz";
            // 
            // FrmSifremiUnuttumÖgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbxSifremiUnuttum);
            this.Controls.Add(this.lblBilgiDoldur);
            this.Name = "FrmSifremiUnuttumÖgrenci";
            this.Text = "SifremiUnuttumÖgrenci";
            this.grbxSifremiUnuttum.ResumeLayout(false);
            this.grbxSifremiUnuttum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxSifremiUnuttum;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSifremiGöster;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblBilgiDoldur;
    }
}