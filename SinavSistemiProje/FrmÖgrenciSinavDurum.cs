using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemiProje
{
    public partial class FrmÖgrenciSinavDurum : Form
    {
        public FrmÖgrenciSinavDurum()
        {
            InitializeComponent();
        }
        public static int ogrid = 0;
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        private void BtnSinavaGir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hazır mısınız?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                FrmÖgrenciSinavModul frmÖgrenciSinavModul = new FrmÖgrenciSinavModul();
                frmÖgrenciSinavModul.Show();
                this.Hide();
            }
        }

        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmÖgrenciAnaSayfa frmÖgrenciAnaSayfa = new FrmÖgrenciAnaSayfa();
            frmÖgrenciAnaSayfa.Show();
            this.Hide();
        }

        private void FrmÖgrenciSinavDurum_Load(object sender, EventArgs e)
        {
            int truecount = questionDetailManager.TrueAnswerCount(ogrid);
            int falsecount = questionDetailManager.FalseAnswerCount(ogrid);
            chart1.Series["SinavDurumu"].Points.AddXY("Dogru Cevap " + truecount, truecount);
            chart1.Series["SinavDurumu"].Points.AddXY("Yanlis Cevap " + falsecount, falsecount);
        }

        private void btnEksikKapa_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hazır mısınız?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                FrmOgrenciSinavModul2 frmOgrenciSinavModul2 = new FrmOgrenciSinavModul2();
                frmOgrenciSinavModul2.id = ogrid;
                frmOgrenciSinavModul2.Show();
                this.Hide();
            }        
        }
    }
}
