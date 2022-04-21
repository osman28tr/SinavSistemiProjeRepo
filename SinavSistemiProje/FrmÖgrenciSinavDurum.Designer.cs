
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavDurumumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSinavaGir = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEksikKapa = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.rctBasariDurumu = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1448, 28);
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
            this.BtnSinavaGir.Location = new System.Drawing.Point(196, 158);
            this.BtnSinavaGir.Name = "BtnSinavaGir";
            this.BtnSinavaGir.Size = new System.Drawing.Size(161, 62);
            this.BtnSinavaGir.TabIndex = 19;
            this.BtnSinavaGir.Text = "Sınava Gir →";
            this.BtnSinavaGir.UseVisualStyleBackColor = true;
            this.BtnSinavaGir.Click += new System.EventHandler(this.BtnSinavaGir_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 226);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "SinavDurumu";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(592, 368);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // btnEksikKapa
            // 
            this.btnEksikKapa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEksikKapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEksikKapa.Location = new System.Drawing.Point(12, 158);
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
            this.btnCiktiAl.Location = new System.Drawing.Point(920, 604);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(161, 62);
            this.btnCiktiAl.TabIndex = 24;
            this.btnCiktiAl.Text = "Yazdir";
            this.btnCiktiAl.UseVisualStyleBackColor = true;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // rctBasariDurumu
            // 
            this.rctBasariDurumu.Location = new System.Drawing.Point(622, 158);
            this.rctBasariDurumu.Name = "rctBasariDurumu";
            this.rctBasariDurumu.Size = new System.Drawing.Size(803, 440);
            this.rctBasariDurumu.TabIndex = 25;
            this.rctBasariDurumu.Text = "";
            // 
            // FrmÖgrenciSinavDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1448, 671);
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
    }
}