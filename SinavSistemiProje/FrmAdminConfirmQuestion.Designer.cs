
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNotConfirm = new System.Windows.Forms.RadioButton();
            this.rbConfirm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.DgwSorular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwSorular_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.rbNotConfirm);
            this.groupBox2.Controls.Add(this.rbConfirm);
            this.groupBox2.Location = new System.Drawing.Point(1035, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 203);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAll.Location = new System.Drawing.Point(105, 158);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(150, 29);
            this.rbAll.TabIndex = 4;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tümünü Getir";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbNotConfirm
            // 
            this.rbNotConfirm.AutoSize = true;
            this.rbNotConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNotConfirm.Location = new System.Drawing.Point(206, 65);
            this.rbNotConfirm.Name = "rbNotConfirm";
            this.rbNotConfirm.Size = new System.Drawing.Size(184, 29);
            this.rbNotConfirm.TabIndex = 1;
            this.rbNotConfirm.TabStop = true;
            this.rbNotConfirm.Text = "Onaylanmayanlar";
            this.rbNotConfirm.UseVisualStyleBackColor = true;
            this.rbNotConfirm.CheckedChanged += new System.EventHandler(this.rbNotConfirm_CheckedChanged);
            // 
            // rbConfirm
            // 
            this.rbConfirm.AutoSize = true;
            this.rbConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbConfirm.Location = new System.Drawing.Point(6, 65);
            this.rbConfirm.Name = "rbConfirm";
            this.rbConfirm.Size = new System.Drawing.Size(147, 29);
            this.rbConfirm.TabIndex = 0;
            this.rbConfirm.TabStop = true;
            this.rbConfirm.Text = "Onaylananlar";
            this.rbConfirm.UseVisualStyleBackColor = true;
            this.rbConfirm.CheckedChanged += new System.EventHandler(this.rbConfirm_CheckedChanged);
            // 
            // FrmAdminConfirmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1443, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "FrmAdminConfirmQuestion";
            this.Text = "FrmAdminConfirmQuestion";
            this.Load += new System.EventHandler(this.FrmAdminConfirmQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgwSorular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNotConfirm;
        private System.Windows.Forms.RadioButton rbConfirm;
        private System.Windows.Forms.RadioButton rbAll;
    }
}