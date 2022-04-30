
namespace SinavSistemiProje
{
    partial class FrmÖgrenciSinavDurum
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavDurumumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSinavaGir = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEksikKapa = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.rctBasariDurumu = new System.Windows.Forms.RichTextBox();
            this.grbxZamanAyarla = new System.Windows.Forms.GroupBox();
            this.btnUygula = new System.Windows.Forms.Button();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSigma6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSigma5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSigma4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSigma3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSigma2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSigma1 = new System.Windows.Forms.ComboBox();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grbxZamanAyarla.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1445, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.profilimToolStripMenuItem.Text = "Profilim";
            this.profilimToolStripMenuItem.Click += new System.EventHandler(this.profilimToolStripMenuItem_Click);
            // 
            // sınavDurumumToolStripMenuItem
            // 
            this.sınavDurumumToolStripMenuItem.Name = "sınavDurumumToolStripMenuItem";
            this.sınavDurumumToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.sınavDurumumToolStripMenuItem.Text = "Sınav Durumum";
            // 
            // BtnSinavaGir
            // 
            this.BtnSinavaGir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavaGir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSinavaGir.Location = new System.Drawing.Point(417, 120);
            this.BtnSinavaGir.Name = "BtnSinavaGir";
            this.BtnSinavaGir.Size = new System.Drawing.Size(178, 62);
            this.BtnSinavaGir.TabIndex = 19;
            this.BtnSinavaGir.Text = "Sınava Gir →";
            this.BtnSinavaGir.UseVisualStyleBackColor = true;
            this.BtnSinavaGir.Click += new System.EventHandler(this.BtnSinavaGir_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 323);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SinavDurumu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(592, 368);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // btnEksikKapa
            // 
            this.btnEksikKapa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEksikKapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEksikKapa.Location = new System.Drawing.Point(417, 52);
            this.btnEksikKapa.Name = "btnEksikKapa";
            this.btnEksikKapa.Size = new System.Drawing.Size(178, 62);
            this.btnEksikKapa.TabIndex = 21;
            this.btnEksikKapa.Text = "Eksiklerimi Kapat";
            this.btnEksikKapa.UseVisualStyleBackColor = true;
            this.btnEksikKapa.Click += new System.EventHandler(this.btnEksikKapa_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(658, 28);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 68);
            this.lblStudent.TabIndex = 22;
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiktiAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCiktiAl.Location = new System.Drawing.Point(921, 701);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(161, 62);
            this.btnCiktiAl.TabIndex = 24;
            this.btnCiktiAl.Text = "Yazdir";
            this.btnCiktiAl.UseVisualStyleBackColor = true;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // rctBasariDurumu
            // 
            this.rctBasariDurumu.Location = new System.Drawing.Point(623, 255);
            this.rctBasariDurumu.Name = "rctBasariDurumu";
            this.rctBasariDurumu.Size = new System.Drawing.Size(803, 440);
            this.rctBasariDurumu.TabIndex = 25;
            this.rctBasariDurumu.Text = "";
            // 
            // grbxZamanAyarla
            // 
            this.grbxZamanAyarla.Controls.Add(this.btnUygula);
            this.grbxZamanAyarla.Controls.Add(this.lblBilgi2);
            this.grbxZamanAyarla.Controls.Add(this.label15);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma6);
            this.grbxZamanAyarla.Controls.Add(this.label14);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma5);
            this.grbxZamanAyarla.Controls.Add(this.label13);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma4);
            this.grbxZamanAyarla.Controls.Add(this.label12);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma3);
            this.grbxZamanAyarla.Controls.Add(this.label11);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma2);
            this.grbxZamanAyarla.Controls.Add(this.label10);
            this.grbxZamanAyarla.Controls.Add(this.cmbSigma1);
            this.grbxZamanAyarla.Controls.Add(this.lblBilgi1);
            this.grbxZamanAyarla.Location = new System.Drawing.Point(13, 43);
            this.grbxZamanAyarla.Name = "grbxZamanAyarla";
            this.grbxZamanAyarla.Size = new System.Drawing.Size(398, 196);
            this.grbxZamanAyarla.TabIndex = 26;
            this.grbxZamanAyarla.TabStop = false;
            this.grbxZamanAyarla.Text = "Zaman Ayarla";
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(76, 155);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(189, 33);
            this.btnUygula.TabIndex = 24;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.lblBilgi2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi2.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi2.Location = new System.Drawing.Point(6, 133);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(354, 19);
            this.lblBilgi2.TabIndex = 24;
            this.lblBilgi2.Text = "Lütfen zamanı gün faktörünü göz önüne alarak belirleyin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(187, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 24);
            this.label15.TabIndex = 36;
            this.label15.Text = "6";
            // 
            // cmbSigma6
            // 
            this.cmbSigma6.FormattingEnabled = true;
            this.cmbSigma6.Location = new System.Drawing.Point(213, 106);
            this.cmbSigma6.Name = "cmbSigma6";
            this.cmbSigma6.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma6.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(187, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 24);
            this.label14.TabIndex = 34;
            this.label14.Text = "5";
            // 
            // cmbSigma5
            // 
            this.cmbSigma5.FormattingEnabled = true;
            this.cmbSigma5.Location = new System.Drawing.Point(213, 78);
            this.cmbSigma5.Name = "cmbSigma5";
            this.cmbSigma5.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma5.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(187, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "4";
            // 
            // cmbSigma4
            // 
            this.cmbSigma4.FormattingEnabled = true;
            this.cmbSigma4.Location = new System.Drawing.Point(213, 47);
            this.cmbSigma4.Name = "cmbSigma4";
            this.cmbSigma4.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma4.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(24, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "3";
            // 
            // cmbSigma3
            // 
            this.cmbSigma3.FormattingEnabled = true;
            this.cmbSigma3.Location = new System.Drawing.Point(50, 106);
            this.cmbSigma3.Name = "cmbSigma3";
            this.cmbSigma3.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma3.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(24, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "2";
            // 
            // cmbSigma2
            // 
            this.cmbSigma2.FormattingEnabled = true;
            this.cmbSigma2.Location = new System.Drawing.Point(50, 77);
            this.cmbSigma2.Name = "cmbSigma2";
            this.cmbSigma2.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(24, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "1";
            // 
            // cmbSigma1
            // 
            this.cmbSigma1.FormattingEnabled = true;
            this.cmbSigma1.Location = new System.Drawing.Point(50, 47);
            this.cmbSigma1.Name = "cmbSigma1";
            this.cmbSigma1.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma1.TabIndex = 25;
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.AutoSize = true;
            this.lblBilgi1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBilgi1.Location = new System.Drawing.Point(45, 14);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Size = new System.Drawing.Size(294, 30);
            this.lblBilgi1.TabIndex = 24;
            this.lblBilgi1.Text = "Lütfen zaman araligini belirleyin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "100 sorudan verdiginiz doğru ve yanlış cevaplar";
            // 
            // FrmÖgrenciSinavDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1445, 772);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbxZamanAyarla);
            this.Controls.Add(this.rctBasariDurumu);
            this.Controls.Add(this.btnCiktiAl);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnEksikKapa);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnSinavaGir);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmÖgrenciSinavDurum";
            this.Text = "Başarı Durumum";
            this.Load += new System.EventHandler(this.FrmÖgrenciSinavDurum_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grbxZamanAyarla.ResumeLayout(false);
            this.grbxZamanAyarla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavDurumumToolStripMenuItem;
        private System.Windows.Forms.Button BtnSinavaGir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnEksikKapa;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnCiktiAl;
        private System.Windows.Forms.RichTextBox rctBasariDurumu;
        private System.Windows.Forms.GroupBox grbxZamanAyarla;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSigma6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSigma5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSigma4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSigma3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSigma2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSigma1;
        private System.Windows.Forms.Label lblBilgi1;
        private System.Windows.Forms.Label label1;
    }
}