
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
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
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
            this.BtnSinavaGir.Location = new System.Drawing.Point(718, 176);
            this.BtnSinavaGir.Name = "BtnSinavaGir";
            this.BtnSinavaGir.Size = new System.Drawing.Size(139, 62);
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
            this.chart1.Location = new System.Drawing.Point(12, 99);
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
            // FrmÖgrenciSinavDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(869, 479);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnSinavaGir);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmÖgrenciSinavDurum";
            this.Text = "FrmÖgrenciSinavDurum";
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
    }
}