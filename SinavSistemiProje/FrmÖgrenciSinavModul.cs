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
        int saniye = 0, dakika = 0, soru = 1/*label'a soruyu yazdırmak icin*/, soruUret = 0;/*db den gelen sorularda kacıncı soruda kaldıgını ögrenmek icin*/
        bool durum = false;/*öğrencinin soruyu bilip bilemediği*/
        List<Question> soruListesi = new List<Question>();
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        WrongAnswerManager wrongAnswerManager = new WrongAnswerManager(new EfWrongAnswerDal());
        SigmaManager sigmaManager = new SigmaManager(new EfSigmaDal());
        int soruSayisi, dogruSoruSayisi;
        private void FrmÖgrenciSinavModul_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Kuralları: Soru başına 1 dk süreniz olacak. Başarılar Dileriz...");
            lblSoru.Text = soru.ToString();
            btnBitir.Visible = false;
            StartTimer();
           
            GenerateQuestions(); //öğrencinin bilemediği veya çözmediği soruların karışık bir şekilde 10 tane gelmesi
            if (GetByQuestionAnswered() == null) //öğrenciye ait dogru soru sayısının kontrolü
                dogruSoruSayisi = 0;
            else
                dogruSoruSayisi = GetByQuestionAnswered().Count;
            soruSayisi = 10 + dogruSoruSayisi;
            FillTheElements();  //soruların ilgili toolbox'lara doldurulması
        }
        private void btnİlerle_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            QuestionDetailUpdate();           
            if (soru == soruSayisi) 
            {
                if (durum == false) 
                {
                    btnBitir.Visible = true;
                    btnİlerle.Enabled = false;
                    if (dogruSoruSayisi == 1) 
                    {
                        QuestionsBySigma6();
                    }
                }
            }
            else if (soru == 11) //ilk 10 soruyu çözdükten sonra 6 sigma yaklaşımına göre ilgili soruların getirilmesi
            {
                QuestionsBySigma6();
            }
            FillTheElements();
        }
        private void QuestionsBySigma6() //6 sigma yaklaşımına göre ilgili soruların getirilmesi
        {
            soruListesi.Clear();
            soruUret = 0;
            soruListesi = GetByQuestionAnswered();
        }
        private bool IsTheQuestionAnsweredCorrectly() //öğrencinin ilgili soruyu doğru bilip bilemediğinin kontrolünün yapılması
        {
            if (rdbA.Checked == true)
                return true;
            return false;
        }
        private void QuestionDetailUpdate() //öğrencinin bir sonraki soruya geçerken çözdüğü soru ile ilgili detail'in güncellenmesi
        {
            bool soruDurum = IsTheQuestionAnsweredCorrectly();

            int questionDetailId = questionDetailManager.GetQuestionDetailId(soruListesi[soruUret - 1].QuestionId, ogrid);
            bool questionDetailState = questionDetailManager.Get(questionDetailId).QuestionState;
            var questionDetailDate = questionDetailManager.Get(questionDetailId).AnsweredDate;
            int sigmaCount = questionDetailManager.Get(questionDetailId).SigmaCount;

            if (questionDetailState == true && soruDurum == true)
            {
                questionDetailManager.Update(new QuestionDetail
                {
                    QuestionDetailId = questionDetailId,
                    QuestionId = soruListesi[soruUret - 1].QuestionId,
                    StudentId = ogrid,
                    QuestionState = soruDurum,
                    AnsweredDate = questionDetailDate,
                    SigmaCount = sigmaCount + 1,
                    AnsweredState = true
                });
            }
            else
            {
                questionDetailManager.Update(new QuestionDetail
                {
                    QuestionDetailId = questionDetailId,
                    QuestionId = soruListesi[soruUret - 1].QuestionId,
                    StudentId = ogrid,
                    QuestionState = soruDurum,
                    AnsweredDate = DateTime.Now,
                    SigmaCount = 0,
                    AnsweredState = true
                });
            }
        }
        private List<Question> GenerateQuestions() //ilk başta öğrencinin önüne 10 tane yanlış bildiği veya hiç çözmediği soruların getirilmesi
        {
            var questionsFalse = questionDetailManager.GetQuestionsByFalse(ogrid);
            soruListesi = questionManager.GetQuestionsByNotAnswered(questionsFalse);
            return soruListesi;
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
            rctxQuestionName.Text = soruListesi[soruUret].QuestionName;
            pcbxQuestionImage.ImageLocation = Application.StartupPath + soruListesi[soruUret].PicturePath;
            txtSecenekA.Text = soruListesi[soruUret].CorrectAnswer;
            txtSecenekB.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[0].WrongAnswerName; 
            txtSecenekC.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[1].WrongAnswerName;
            txtSecenekD.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[2].WrongAnswerName;
            soruUret++;
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
            MessageBox.Show("Cevap Kağıdınız: 1-" + soruSayisi + " arası A şıkkıdır");
        }
    }
}
