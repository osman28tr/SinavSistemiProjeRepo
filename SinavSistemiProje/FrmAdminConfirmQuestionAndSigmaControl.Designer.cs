
namespace SinavSistemiProje
{
    partial class FrmAdminConfirmQuestionAndSigmaControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUygula = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(405, 9);
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
            this.groupBox2.Size = new System.Drawing.Size(570, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAll.Location = new System.Drawing.Point(185, 136);
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
            this.rbNotConfirm.Location = new System.Drawing.Point(364, 65);
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
            this.rbConfirm.Location = new System.Drawing.Point(26, 65);
            this.rbConfirm.Name = "rbConfirm";
            this.rbConfirm.Size = new System.Drawing.Size(147, 29);
            this.rbConfirm.TabIndex = 0;
            this.rbConfirm.TabStop = true;
            this.rbConfirm.Text = "Onaylananlar";
            this.rbConfirm.UseVisualStyleBackColor = true;
            this.rbConfirm.CheckedChanged += new System.EventHandler(this.rbConfirm_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUygula);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmbSigma6);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbSigma5);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbSigma4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbSigma3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbSigma2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbSigma1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1041, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 249);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zaman Ayarla";
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(153, 188);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(189, 33);
            this.btnUygula.TabIndex = 37;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(78, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(354, 19);
            this.label16.TabIndex = 38;
            this.label16.Text = "Lütfen zamanı gün faktörünü göz önüne alarak belirleyin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(259, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 24);
            this.label15.TabIndex = 51;
            this.label15.Text = "6";
            // 
            // cmbSigma6
            // 
            this.cmbSigma6.FormattingEnabled = true;
            this.cmbSigma6.Location = new System.Drawing.Point(285, 139);
            this.cmbSigma6.Name = "cmbSigma6";
            this.cmbSigma6.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma6.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(259, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 24);
            this.label14.TabIndex = 49;
            this.label14.Text = "5";
            // 
            // cmbSigma5
            // 
            this.cmbSigma5.FormattingEnabled = true;
            this.cmbSigma5.Location = new System.Drawing.Point(285, 111);
            this.cmbSigma5.Name = "cmbSigma5";
            this.cmbSigma5.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma5.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(259, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 47;
            this.label13.Text = "4";
            // 
            // cmbSigma4
            // 
            this.cmbSigma4.FormattingEnabled = true;
            this.cmbSigma4.Location = new System.Drawing.Point(285, 80);
            this.cmbSigma4.Name = "cmbSigma4";
            this.cmbSigma4.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma4.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(96, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "3";
            // 
            // cmbSigma3
            // 
            this.cmbSigma3.FormattingEnabled = true;
            this.cmbSigma3.Location = new System.Drawing.Point(122, 139);
            this.cmbSigma3.Name = "cmbSigma3";
            this.cmbSigma3.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma3.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(96, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 43;
            this.label11.Text = "2";
            // 
            // cmbSigma2
            // 
            this.cmbSigma2.FormattingEnabled = true;
            this.cmbSigma2.Location = new System.Drawing.Point(122, 110);
            this.cmbSigma2.Name = "cmbSigma2";
            this.cmbSigma2.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma2.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(96, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "1";
            // 
            // cmbSigma1
            // 
            this.cmbSigma1.FormattingEnabled = true;
            this.cmbSigma1.Location = new System.Drawing.Point(122, 80);
            this.cmbSigma1.Name = "cmbSigma1";
            this.cmbSigma1.Size = new System.Drawing.Size(121, 24);
            this.cmbSigma1.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(117, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Lütfen zaman araligini belirleyin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ogrencinin Dogru Cozdugu Sorularla İlgili Zamani Ayarlayabilirsiniz";
            // 
            // FrmAdminConfirmQuestionAndSigmaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1611, 730);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "FrmAdminConfirmQuestionAndSigmaControl";
            this.Text = "Adminİslem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminConfirmQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.Label label9;
    }
}