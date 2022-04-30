
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
            this.grbxSifremiUnuttum = new System.Windows.Forms.GroupBox();
            this.txtAdminMail = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnSifremiGöster = new System.Windows.Forms.Button();
            this.lblAdminMail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblBilgiDoldur = new System.Windows.Forms.Label();
            this.grbxSifremiUnuttum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxSifremiUnuttum
            // 
            this.grbxSifremiUnuttum.Controls.Add(this.txtAdminMail);
            this.grbxSifremiUnuttum.Controls.Add(this.txtAdminName);
            this.grbxSifremiUnuttum.Controls.Add(this.btnSifremiGöster);
            this.grbxSifremiUnuttum.Controls.Add(this.lblAdminMail);
            this.grbxSifremiUnuttum.Controls.Add(this.lblAdminName);
            this.grbxSifremiUnuttum.Location = new System.Drawing.Point(138, 100);
            this.grbxSifremiUnuttum.Name = "grbxSifremiUnuttum";
            this.grbxSifremiUnuttum.Size = new System.Drawing.Size(516, 265);
            this.grbxSifremiUnuttum.TabIndex = 5;
            this.grbxSifremiUnuttum.TabStop = false;
            this.grbxSifremiUnuttum.Text = "Şifremi Unuttum";
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
            // lblAdminMail
            // 
            this.lblAdminMail.AutoSize = true;
            this.lblAdminMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminMail.ForeColor = System.Drawing.Color.Green;
            this.lblAdminMail.Location = new System.Drawing.Point(6, 110);
            this.lblAdminMail.Name = "lblAdminMail";
            this.lblAdminMail.Size = new System.Drawing.Size(112, 25);
            this.lblAdminMail.TabIndex = 3;
            this.lblAdminMail.Text = "AdminMail:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminName.ForeColor = System.Drawing.Color.Green;
            this.lblAdminName.Location = new System.Drawing.Point(6, 28);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(126, 25);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "AdminName:";
            // 
            // lblBilgiDoldur
            // 
            this.lblBilgiDoldur.AutoSize = true;
            this.lblBilgiDoldur.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiDoldur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBilgiDoldur.Location = new System.Drawing.Point(126, 9);
            this.lblBilgiDoldur.Name = "lblBilgiDoldur";
            this.lblBilgiDoldur.Size = new System.Drawing.Size(546, 68);
            this.lblBilgiDoldur.TabIndex = 4;
            this.lblBilgiDoldur.Text = "Lütfen Bilgileri Doldurunuz";
            // 
            // FrmSifremiUnuttumAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbxSifremiUnuttum);
            this.Controls.Add(this.lblBilgiDoldur);
            this.Name = "FrmSifremiUnuttumAdmin";
            this.Text = "SifremiUnuttumAdmin";
            this.grbxSifremiUnuttum.ResumeLayout(false);
            this.grbxSifremiUnuttum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxSifremiUnuttum;
        private System.Windows.Forms.TextBox txtAdminMail;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnSifremiGöster;
        private System.Windows.Forms.Label lblAdminMail;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblBilgiDoldur;
    }
}