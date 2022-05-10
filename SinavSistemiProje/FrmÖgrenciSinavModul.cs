using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
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
    public partial class FrmÖgrenciSinavModul : Form
    {
        public FrmÖgrenciSinavModul()
        {
            InitializeComponent();
        }
        public static int ogrid = 0;
        int saniye = 0, dakika = 0, soru = 1, soruüret = 0;
        bool durum = false; 
        List<Question> sorulistesi = new List<Question>();
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        WrongAnswerManager wrongAnswerManager = new WrongAnswerManager(new EfWrongAnswerDal());
        SigmaManager sigmaManager = new SigmaManager(new EfSigmaDal());
        int sorusayisi, dogrusorusayisi;
        private void FrmÖgrenciSinavModul_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Kuralları: Soru başına 1 dk süreniz olacak. Başarılar Dileriz...");
            lblSoru.Text = soru.ToString();
            btnBitir.Visible = false;
            StartTimer();
           
            GenerateQuestions();
            if (GetByQuestionAnswered() == null)      
                dogrusorusayisi = 0;
            else
                dogrusorusayisi = GetByQuestionAnswered().Count;
            sorusayisi = 10 + dogrusorusayisi;
            FillTheElements(); 
        }
        private void btnİlerle_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            QuestionDetailUpdate();           
            if (soru == sorusayisi) 
            {
                if (durum == false) 
                {
                    btnBitir.Visible = true;
                    btnİlerle.Enabled = false;
                    if (dogrusorusayisi == 1) 
                    {
                        QuestionsBySigma6();
                    }
                }
            }
            else if (soru == 11)
            {
                QuestionsBySigma6();
            }
            FillTheElements();
        }
        private void QuestionsBySigma6()
        {
            sorulistesi.Clear();
            soruüret = 0;
            sorulistesi = GetByQuestionAnswered();
        }
        private bool IsTheQuestionAnsweredCorrectly() 
        {
            if (rdbA.Checked == true)
                return true;
            return false;
        }
        private void QuestionDetailUpdate() 
        {
            bool sorudurum = IsTheQuestionAnsweredCorrectly();

            int questiondetailid = questionDetailManager.GetQuestionDetailId(sorulistesi[soruüret - 1].QuestionId, ogrid);
            bool questiondetailstate = questionDetailManager.Get(questiondetailid).QuestionState;
            var questiondetaildate = questionDetailManager.Get(questiondetailid).AnsweredDate;
            int sigmacount = questionDetailManager.Get(questiondetailid).SigmaCount;

            if (questiondetailstate == true && sorudurum == true)
            {
                questionDetailManager.Update(new QuestionDetail
                {
                    QuestionDetailId = questiondetailid,
                    QuestionId = sorulistesi[soruüret - 1].QuestionId,
                    StudentId = ogrid,
                    QuestionState = sorudurum,
                    AnsweredDate = questiondetaildate,
                    SigmaCount = sigmacount + 1,
                    AnsweredState = true
                });
            }
            else
            {
                questionDetailManager.Update(new QuestionDetail
                {
                    QuestionDetailId = questiondetailid,
                    QuestionId = sorulistesi[soruüret - 1].QuestionId,
                    StudentId = ogrid,
                    QuestionState = sorudurum,
                    AnsweredDate = DateTime.Now,
                    SigmaCount = 0,
                    AnsweredState = true
                });
            }
        }
        private List<Question> GenerateQuestions() 
        {
            var questionsfalse = questionDetailManager.GetQuestionsByFalse(ogrid);
            sorulistesi = questionManager.GetQuestionsByNotAnswered(questionsfalse);
            return sorulistesi;
        }
        private List<Question> GetByQuestionAnswered()
        {
            List<QuestionDetail> questionDetails = new List<QuestionDetail>();
            Sigma sigma = sigmaManager.Get();
            questionDetails = questionDetailManager.GetQuestionsAnsweredByDate(ogrid, sigma);
            var questions = questionManager.GetQuestionsByAnswered(questionDetails);
            return questions;
        }
        private void FillTheElements() 
        {
            rctxQuestionName.Text = sorulistesi[soruüret].QuestionName;
            pcbxQuestionImage.ImageLocation = Application.StartupPath + sorulistesi[soruüret].PicturePath;
            txtSecenekA.Text = sorulistesi[soruüret].CorrectAnswer;
            txtSecenekB.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[0].WrongAnswerName; 
            txtSecenekC.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[1].WrongAnswerName;
            txtSecenekD.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[2].WrongAnswerName;
            soruüret++;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Emin Misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                timer1.Stop();
                QuestionDetailUpdate();
                MessageBox.Show("Cevaplarınız Gönderildi! Geçmiş Olsun :)...");
                ShowAnswers();
                Finished();
            }
        }

        private void StartTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSaniye.Text = saniye + " sn";
            if (saniye == 60)
            {
                dakika++;
                lblSaniye.Text = "0";
                lblDakika.Text = dakika + " dk";
                saniye = 0;
                if (dakika == 10)
                {
                    timer1.Stop();
                    durum = true; 
                    MessageBox.Show("Süreniz Bitmiştir. Cevaplarınız Gönderildi. Geçmiş Olsun. :)");
                    ShowAnswers();
                    Finished();
                }
            }
        }
        private void Finished()
        {
            FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
            frmÖgrenci.Show();
            this.Hide();
        }
        private void ShowAnswers()
        {
            MessageBox.Show("Cevap Kağıdınız: 1-" + sorusayisi + " arası A şıkkıdır");
        }
    }
}
