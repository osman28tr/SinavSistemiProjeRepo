
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
            this.lblHosGeldiniz = new System.Windows.Forms.Label();
            this.grbxSorular = new System.Windows.Forms.GroupBox();
            this.DgwSorular = new System.Windows.Forms.DataGridView();
            this.grbxFiltrele = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNotConfirm = new System.Windows.Forms.RadioButton();
            this.rbConfirm = new System.Windows.Forms.RadioButton();
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
            this.lblZamanAraligi = new System.Windows.Forms.Label();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.grbxSorular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).BeginInit();
            this.grbxFiltrele.SuspendLayout();
            this.grbxZamanAyarla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHosGeldiniz
            // 
            this.lblHosGeldiniz.AutoSize = true;
            this.lblHosGeldiniz.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosGeldiniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHosGeldiniz.Location = new System.Drawing.Point(405, 9);
            this.lblHosGeldiniz.Name = "lblHosGeldiniz";
            this.lblHosGeldiniz.Size = new System.Drawing.Size(275, 54);
            this.lblHosGeldiniz.TabIndex = 3;
            this.lblHosGeldiniz.Text = "HOŞ GELDİNİZ...";
            // 
            // grbxSorular
            // 
            this.grbxSorular.Controls.Add(this.DgwSorular);
            this.grbxSorular.Location = new System.Drawing.Point(12, 66);
            this.grbxSorular.Name = "grbxSorular";
            this.grbxSorular.Size = new System.Drawing.Size(1017, 652);
            this.grbxSorular.TabIndex = 8;
            this.grbxSorular.TabStop = false;
            this.grbxSorular.Text = "Sorular";
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
            // grbxFiltrele
            // 
            this.grbxFiltrele.Controls.Add(this.rbAll);
            this.grbxFiltrele.Controls.Add(this.rbNotConfirm);
            this.grbxFiltrele.Controls.Add(this.rbConfirm);
            this.grbxFiltrele.Location = new System.Drawing.Point(1035, 75);
            this.grbxFiltrele.Name = "grbxFiltrele";
            this.grbxFiltrele.Size = new System.Drawing.Size(570, 271);
            this.grbxFiltrele.TabIndex = 9;
            this.grbxFiltrele.TabStop = false;
            this.grbxFiltrele.Text = "Filtrele";
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
            this.grbxZamanAyarla.Controls.Add(this.lblZamanAraligi);
            this.grbxZamanAyarla.Controls.Add(this.lblBilgi1);
            this.grbxZamanAyarla.Location = new System.Drawing.Point(1041, 352);
            this.grbxZamanAyarla.Name = "grbxZamanAyarla";
            this.grbxZamanAyarla.Size = new System.Drawing.Size(570, 249);
            this.grbxZamanAyarla.TabIndex = 10;
            this.grbxZamanAyarla.TabStop = false;
            this.grbxZamanAyarla.Text = "Zaman Ayarla";
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
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.lblBilgi2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi2.ForeColor = System.Drawing.Color.White;
            this.lblBilgi2.Location = new System.Drawing.Point(78, 166);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(354, 19);
            this.lblBilgi2.TabIndex = 38;
            this.lblBilgi2.Text = "Lütfen zamanı gün faktörünü göz önüne alarak belirleyin";
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
            // lblZamanAraligi
            // 
            this.lblZamanAraligi.AutoSize = true;
            this.lblZamanAraligi.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZamanAraligi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZamanAraligi.Location = new System.Drawing.Point(117, 47);
            this.lblZamanAraligi.Name = "lblZamanAraligi";
            this.lblZamanAraligi.Size = new System.Drawing.Size(294, 30);
            this.lblZamanAraligi.TabIndex = 39;
            this.lblZamanAraligi.Text = "Lütfen zaman araligini belirleyin";
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.AutoSize = true;
            this.lblBilgi1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi1.ForeColor = System.Drawing.Color.White;
            this.lblBilgi1.Location = new System.Drawing.Point(16, 18);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Size = new System.Drawing.Size(548, 22);
            this.lblBilgi1.TabIndex = 11;
            this.lblBilgi1.Text = "Ogrencinin Dogru Cozdugu Sorularla İlgili Zamani Ayarlayabilirsiniz";
            // 
            // FrmAdminConfirmQuestionAndSigmaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1611, 730);
            this.Controls.Add(this.grbxZamanAyarla);
            this.Controls.Add(this.grbxFiltrele);
            this.Controls.Add(this.grbxSorular);
            this.Controls.Add(this.lblHosGeldiniz);
            this.Name = "FrmAdminConfirmQuestionAndSigmaControl";
            this.Text = "Adminİslem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminConfirmQuestion_Load);
            this.grbxSorular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwSorular)).EndInit();
            this.grbxFiltrele.ResumeLayout(false);
            this.grbxFiltrele.PerformLayout();
            this.grbxZamanAyarla.ResumeLayout(false);
            this.grbxZamanAyarla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosGeldiniz;
        private System.Windows.Forms.GroupBox grbxSorular;
        private System.Windows.Forms.DataGridView DgwSorular;
        private System.Windows.Forms.GroupBox grbxFiltrele;
        private System.Windows.Forms.RadioButton rbNotConfirm;
        private System.Windows.Forms.RadioButton rbConfirm;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox grbxZamanAyarla;
        private System.Windows.Forms.Label lblBilgi1;
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
        private System.Windows.Forms.Label lblZamanAraligi;
    }
}