
namespace SinavSistemiProje
{
    partial class FrmÖgrenciSinavModul
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
            this.components = new System.ComponentModel.Container();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDakika = new System.Windows.Forms.Label();
            this.pcbxQuestionImage = new System.Windows.Forms.PictureBox();
            this.rctxQuestionName = new System.Windows.Forms.RichTextBox();
            this.lblSoruAdi = new System.Windows.Forms.Label();
            this.grbxSecenekler = new System.Windows.Forms.GroupBox();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.txtSecenekD = new System.Windows.Forms.TextBox();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.txtSecenekC = new System.Windows.Forms.TextBox();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.txtSecenekB = new System.Windows.Forms.TextBox();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.txtSecenekA = new System.Windows.Forms.TextBox();
            this.btnİlerle = new System.Windows.Forms.Button();
            this.lblBilgiSoru = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQuestionImage)).BeginInit();
            this.grbxSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSure.Location = new System.Drawing.Point(12, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(84, 28);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "Süreniz:";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSaniye.Location = new System.Drawing.Point(153, 9);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(23, 28);
            this.lblSaniye.TabIndex = 2;
            this.lblSaniye.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDakika.Location = new System.Drawing.Point(102, 9);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(23, 28);
            this.lblDakika.TabIndex = 3;
            this.lblDakika.Text = "0";
            // 
            // pcbxQuestionImage
            // 
            this.pcbxQuestionImage.Location = new System.Drawing.Point(329, 299);
            this.pcbxQuestionImage.Name = "pcbxQuestionImage";
            this.pcbxQuestionImage.Size = new System.Drawing.Size(1046, 384);
            this.pcbxQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxQuestionImage.TabIndex = 19;
            this.pcbxQuestionImage.TabStop = false;
            // 
            // rctxQuestionName
            // 
            this.rctxQuestionName.Location = new System.Drawing.Point(329, 16);
            this.rctxQuestionName.Name = "rctxQuestionName";
            this.rctxQuestionName.Size = new System.Drawing.Size(1046, 268);
            this.rctxQuestionName.TabIndex = 17;
            this.rctxQuestionName.Text = "";
            // 
            // lblSoruAdi
            // 
            this.lblSoruAdi.AutoSize = true;
            this.lblSoruAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoruAdi.Location = new System.Drawing.Point(228, 25);
            this.lblSoruAdi.Name = "lblSoruAdi";
            this.lblSoruAdi.Size = new System.Drawing.Size(95, 28);
            this.lblSoruAdi.TabIndex = 16;
            this.lblSoruAdi.Text = "Soru Adı:";
            // 
            // grbxSecenekler
            // 
            this.grbxSecenekler.Controls.Add(this.lblBilgi1);
            this.grbxSecenekler.Controls.Add(this.rdbD);
            this.grbxSecenekler.Controls.Add(this.txtSecenekD);
            this.grbxSecenekler.Controls.Add(this.rdbC);
            this.grbxSecenekler.Controls.Add(this.txtSecenekC);
            this.grbxSecenekler.Controls.Add(this.rdbB);
            this.grbxSecenekler.Controls.Add(this.txtSecenekB);
            this.grbxSecenekler.Controls.Add(this.rdbA);
            this.grbxSecenekler.Controls.Add(this.txtSecenekA);
            this.grbxSecenekler.Location = new System.Drawing.Point(346, 689);
            this.grbxSecenekler.Name = "grbxSecenekler";
            this.grbxSecenekler.Size = new System.Drawing.Size(847, 287);
            this.grbxSecenekler.TabIndex = 20;
            this.grbxSecenekler.TabStop = false;
            this.grbxSecenekler.Text = "Seçenekler";
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.AutoSize = true;
            this.lblBilgi1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi1.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi1.Location = new System.Drawing.Point(12, 256);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Size = new System.Drawing.Size(353, 19);
            this.lblBilgi1.TabIndex = 15;
            this.lblBilgi1.Text = "Lütfen Doğru Cevabı Seçeneklerdeki Optiğe İşaretleyin!!!";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbD.Location = new System.Drawing.Point(24, 213);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(43, 27);
            this.rdbD.TabIndex = 7;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // txtSecenekD
            // 
            this.txtSecenekD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecenekD.Location = new System.Drawing.Point(86, 204);
            this.txtSecenekD.Multiline = true;
            this.txtSecenekD.Name = "txtSecenekD";
            this.txtSecenekD.Size = new System.Drawing.Size(533, 49);
            this.txtSecenekD.TabIndex = 6;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbC.Location = new System.Drawing.Point(23, 146);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(42, 27);
            this.rdbC.TabIndex = 5;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // txtSecenekC
            // 
            this.txtSecenekC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecenekC.Location = new System.Drawing.Point(86, 146);
            this.txtSecenekC.Multiline = true;
            this.txtSecenekC.Name = "txtSecenekC";
            this.txtSecenekC.Size = new System.Drawing.Size(533, 51);
            this.txtSecenekC.TabIndex = 4;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbB.Location = new System.Drawing.Point(23, 84);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(41, 27);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // txtSecenekB
            // 
            this.txtSecenekB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecenekB.Location = new System.Drawing.Point(86, 84);
            this.txtSecenekB.Multiline = true;
            this.txtSecenekB.Name = "txtSecenekB";
            this.txtSecenekB.Size = new System.Drawing.Size(533, 56);
            this.txtSecenekB.TabIndex = 2;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbA.Location = new System.Drawing.Point(24, 25);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(42, 27);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // txtSecenekA
            // 
            this.txtSecenekA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecenekA.Location = new System.Drawing.Point(86, 25);
            this.txtSecenekA.Multiline = true;
            this.txtSecenekA.Name = "txtSecenekA";
            this.txtSecenekA.Size = new System.Drawing.Size(533, 53);
            this.txtSecenekA.TabIndex = 0;
            // 
            // btnİlerle
            // 
            this.btnİlerle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİlerle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnİlerle.Location = new System.Drawing.Point(1199, 699);
            this.btnİlerle.Name = "btnİlerle";
            this.btnİlerle.Size = new System.Drawing.Size(179, 54);
            this.btnİlerle.TabIndex = 21;
            this.btnİlerle.Text = "İLERLE →";
            this.btnİlerle.UseVisualStyleBackColor = true;
            this.btnİlerle.Click += new System.EventHandler(this.btnİlerle_Click);
            // 
            // lblBilgiSoru
            // 
            this.lblBilgiSoru.AutoSize = true;
            this.lblBilgiSoru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBilgiSoru.Location = new System.Drawing.Point(12, 37);
            this.lblBilgiSoru.Name = "lblBilgiSoru";
            this.lblBilgiSoru.Size = new System.Drawing.Size(59, 28);
            this.lblBilgiSoru.TabIndex = 22;
            this.lblBilgiSoru.Text = "Soru:";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoru.Location = new System.Drawing.Point(102, 37);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(23, 28);
            this.lblSoru.TabIndex = 23;
            this.lblSoru.Text = "0";
            // 
            // btnBitir
            // 
            this.btnBitir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBitir.Location = new System.Drawing.Point(1199, 757);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(179, 54);
            this.btnBitir.TabIndex = 24;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // FrmÖgrenciSinavModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1419, 1055);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.lblBilgiSoru);
            this.Controls.Add(this.btnİlerle);
            this.Controls.Add(this.grbxSecenekler);
            this.Controls.Add(this.pcbxQuestionImage);
            this.Controls.Add(this.rctxQuestionName);
            this.Controls.Add(this.lblSoruAdi);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblSure);
            this.Name = "FrmÖgrenciSinavModul";
            this.Text = "SinavModul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmÖgrenciSinavModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQuestionImage)).EndInit();
            this.grbxSecenekler.ResumeLayout(false);
            this.grbxSecenekler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.PictureBox pcbxQuestionImage;
        private System.Windows.Forms.RichTextBox rctxQuestionName;
        private System.Windows.Forms.Label lblSoruAdi;
        private System.Windows.Forms.GroupBox grbxSecenekler;
        private System.Windows.Forms.Label lblBilgi1;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.TextBox txtSecenekD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.TextBox txtSecenekC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.TextBox txtSecenekB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.TextBox txtSecenekA;
        private System.Windows.Forms.Button btnİlerle;
        private System.Windows.Forms.Label lblBilgiSoru;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Button btnBitir;
    }
}