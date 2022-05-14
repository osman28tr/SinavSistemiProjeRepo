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
    public partial class FrmOgrenciSinavModulEksikKapa : Form
    {
        public FrmOgrenciSinavModulEksikKapa()
        {
            InitializeComponent();
        }
        public int ogrid = 0;
        int soruUret = 0, soru = 1, saniye = 0, dakika = 0, sayac = 0;
        bool durum = false;
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        WrongAnswerManager wrongAnswerManager = new WrongAnswerManager(new EfWrongAnswerDal());
        SubjectManager subjectManager = new SubjectManager(new EfSubjectDal());
        List<Question> soruListesi = new List<Question>();
        private void FrmOgrenciSinavModul2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Kuralları: Soru başına 1 dk süreniz olacak. Başarılar Dileriz...");
            lblSoru.Text = soru.ToString();
            btnBitir.Visible = false;
            StartTimer(); //timer'ın başlatılması
            GenerateQuestions(); //soruların getirilmesi
            FillTheElements(); //soruların gösterilmesi
        }
        private void FillTheElements()
        {
            rctxQuestionName.Text = soruListesi[soruUret].QuestionName;
            pcbQuestionİmage.ImageLocation = Application.StartupPath + soruListesi[soruUret].PicturePath;
            txtSecenekA.Text = soruListesi[soruUret].CorrectAnswer;
            txtSecenekB.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[0].WrongAnswerName;
            txtSecenekC.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[1].WrongAnswerName;
            txtSecenekD.Text = wrongAnswerManager.GetAll(soruListesi[soruUret].QuestionId)[2].WrongAnswerName;
            soruUret++;
        }

        private void btnİlerle_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            if (soru == sayac)
            {
                if (durum == false)
                {
                    btnBitir.Visible = true;
                    btnİlerle.Enabled = false;
                }
            }
            FillTheElements();
        }
        private List<Question> GenerateQuestions()
        {
            List<Question> questions;
            int count = subjectManager.SubjectCount(); //konu sayısını alır.
            int countSuccess = 0, countNotSuccess = 0; //öğrencinin ilgili konudan doğru ve yanlış cevap sayısını tutar.
            for (int i = 1; i <= count; i++) //konu sayısına kadar gider.
            {
                int questionBySubjectCount = questionManager.QuestionBySubject(i); //ilgili konudan sorulan soru sayısını verir.
                questions = questionManager.GetAll().Where(x => x.SubjectId == i).ToList(); //ilgili konudan sorulan soru listesini verir.
                for (int j = 0; j < questionBySubjectCount; j++) //ilgili konudan sorulan soru sayısına kadar gider.
                {
                    int questionId = questions[j].QuestionId; //ilgili sorunun soru id sini alır.
                    countSuccess = countSuccess + questionDetailManager.StudentSuccessQuestionBySubject(questionId, ogrid); //öğrencinin ilgili konudan verdiği doğru cevap sayısını verir.
                    countNotSuccess = countNotSuccess + questionDetailManager.StudentNotSuccessQuestionBySubject(questionId, ogrid); //öğrencinin ilgili konudan verdiği yanlış cevap sayısını verir.
                }
                if (countNotSuccess > countSuccess) //eğer yanlış cevap sayısı doğru cevap sayısından fazla ise öğrenci o konudan eksiği vardır. ve o konudan sorular karşısına gelir.
                {
                    for (int j = 1; j <= questionBySubjectCount; j++) //sorular ilgili soruListesine eklenir.
                    {
                        soruListesi.Add(questions[j - 1]);
                        sayac++;
                    }
                }
                countSuccess = 0;
                countNotSuccess = 0;
            }
            return soruListesi;
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Emin Misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                timer1.Stop();
                MessageBox.Show("Umarız Hatalarınızı Görüp Ders Çıkarmışsınızdır :)...");
                ShowAnswers();//cevap kağıdı
                Finished(); //sınav bitince ilgili forma yönlendirir.
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
                if (dakika == sayac)
                {
                    timer1.Stop();
                    durum = true;
                    MessageBox.Show("Süreniz Bitmiştir. Geçmiş Olsun. :)");
                    ShowAnswers(); //cevap kağıdı
                    Finished();
                }
            }
        }
        private void Finished() //sınav bitince ilgili forma yönlendirir.
        {
            FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
            frmÖgrenci.Show();
            this.Hide();
        }
        private void ShowAnswers()
        {
            MessageBox.Show("Cevap Kağıdınız: 1-" + sayac + " arası A şıkkıdır");         
        }
    }
}
