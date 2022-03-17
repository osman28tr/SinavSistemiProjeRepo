
namespace SinavSistemiProje
{
    partial class FrmAdminConfirmQuestion
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgwSorular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "HOŞ GELDİNİZ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgwSorular);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 652);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorular";
            // 
            // DgwSorular
            // 
            this.DgwSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwSorular.Location = new System.Drawing.Point(6, 21);
            this.DgwSorular.Name = "DgwSorular";
            this.DgwSorular.RowHeadersWidth = 51;
            this.DgwSorular.RowTemplate.Height = 24;
            this.DgwSorular.Size = new System.Drawing.Size(1005, 625);
            this.DgwSorular.TabIndex = 9;
            this.DgwSorular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwSorular_CellClick);
            this.DgwSorular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwSorular_CellDoubleClick);
            // 
            // FrmAdminConfirmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1041, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "FrmAdminConfirmQuestion";
            this.Text = "FrmAdminConfirmQuestion";
            this.Load += new System.EventHandler(this.FrmAdminConfirmQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgwSorular;
    }
}