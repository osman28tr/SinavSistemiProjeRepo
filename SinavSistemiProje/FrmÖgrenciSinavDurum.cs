using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        SubjectManager subjectManager = new SubjectManager(new EfSubjectDal());
        SigmaManager sigmaManager = new SigmaManager(new EfSigmaDal());
        PrintDialog Prd = new PrintDialog();
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
            lblStudent.Text = studentManager.Get(ogrid).StudentName;

            FillSigma();
            GetSuccessStatus();
        }
        private void FillSigma()
        {
            for (int i = 1; i <= 365; i++)
            {
                cmbSigma1.Items.Add(i);
                cmbSigma2.Items.Add(i);
                cmbSigma3.Items.Add(i);
                cmbSigma4.Items.Add(i);
                cmbSigma5.Items.Add(i);
                cmbSigma6.Items.Add(i);
            }
        }
        private void GetSuccessStatus() //öğrenciye ait sınav verilerinin gösterilmesi
        {
            int count = subjectManager.SubjectCount();
            double countSuccess = 0, countNotSuccess = 0, countEmpty = 0;
            double successState;
            for (int i = 1; i <= count; i++)
            {
                double questionBySubjectCount = questionManager.QuestionBySubject(i);
                string subjectName = subjectManager.GetSubjectById(i).SubjectName;
                List<Question> questions = questionManager.GetAll().Where(x => x.SubjectId == i).ToList();
                for (int j = 0; j < questionBySubjectCount; j++)
                {
                    int questionId = questions[j].QuestionId;
                    countSuccess = countSuccess + questionDetailManager.StudentSuccessQuestionBySubject(questionId, ogrid);
                    countNotSuccess = countNotSuccess + questionDetailManager.StudentNotSuccessQuestionBySubject(questionId, ogrid);
                    countEmpty = countEmpty + questionDetailManager.StudentEmptyQuestionBySubject(questionId, ogrid);
                }
                if ((questionBySubjectCount - countEmpty) != 0 && countSuccess != 0)
                    successState = (countSuccess / (questionBySubjectCount - countEmpty)) * 100;
                else
                    successState = 0;
                successState = Math.Round(successState);
                if ((countSuccess + countNotSuccess + countEmpty) != questionBySubjectCount)
                    questionBySubjectCount = countSuccess + countNotSuccess + countEmpty;
                rctBasariDurumu.Text = rctBasariDurumu.Text + subjectName + " Konulu sorulardan " + " Size sorulan, " + questionBySubjectCount + " adet sorudan "
                + countSuccess +
                " soruyu doğru " + countNotSuccess + " soruyu yanlis " +
                "bildiniz" + countEmpty + " soruyu ise henüz çözmediniz " + " % " + successState + " basarili oldunuz!!!\n";
                countSuccess = 0;
                countNotSuccess = 0;
                countEmpty = 0;

            }
        }
        private void btnEksikKapa_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hazır mısınız?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                FrmOgrenciSinavModul2 frmOgrenciSinavModul2 = new FrmOgrenciSinavModul2();
                frmOgrenciSinavModul2.ogrid = ogrid;
                frmOgrenciSinavModul2.Show();
                this.Hide();
            }
        }

        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            PrintDocument Paper = new PrintDocument();
            DialogResult writingProcess;
            writingProcess = Prd.ShowDialog();
            Paper.PrintPage += Paper_PrintPage;
            if (writingProcess == DialogResult.OK)
            {
                Paper.Print();
            }
        }

        private void Paper_PrintPage(object sender, PrintPageEventArgs e)
        {
            string write = rctBasariDurumu.Text;
            Font writeFamily = new Font("Arial", 12);
            SolidBrush pencil = new SolidBrush(Color.Black);
            e.Graphics.DrawString(write, writeFamily, pencil, 10, 20);
        }

        private void btnUygula_Click(object sender, EventArgs e) //6 sigma yaklaşımının ayarlanması
        {
            if (sigmaManager.GetAll().Count > 0)
            {
                sigmaManager.Update(new Sigma
                {
                    SigmaId = 1,
                    Sigma1 = Convert.ToInt32(cmbSigma1.Text),
                    Sigma2 = Convert.ToInt32(cmbSigma2.Text),
                    Sigma3 = Convert.ToInt32(cmbSigma3.Text),
                    Sigma4 = Convert.ToInt32(cmbSigma4.Text),
                    Sigma5 = Convert.ToInt32(cmbSigma5.Text),
                    Sigma6 = Convert.ToInt32(cmbSigma6.Text),
                });
            }
            else
            {
                sigmaManager.Add(new Sigma
                {
                    Sigma1 = Convert.ToInt32(cmbSigma1.Text),
                    Sigma2 = Convert.ToInt32(cmbSigma2.Text),
                    Sigma3 = Convert.ToInt32(cmbSigma3.Text),
                    Sigma4 = Convert.ToInt32(cmbSigma4.Text),
                    Sigma5 = Convert.ToInt32(cmbSigma5.Text),
                    Sigma6 = Convert.ToInt32(cmbSigma6.Text),
                });
            }
            MessageBox.Show("Belirlediğiniz zaman aralıkları başarıyla uygulandı");
        }
    }
}
