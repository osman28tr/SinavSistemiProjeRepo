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
        public static int id = 0;
        int saniye = 0, dakika = 0, soru = 1/*label'a soruyu yazdırmak için*/, soruüret = 0;/*database'den gelen sorularda kaçıncı soruda kaldığını öğrenmek için (indis)*/
        bool durum = false; /*öğrencinin soruyu bilip bilemediği*/
        List<Question> sorulistesi = new List<Question>();
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        int sorusayisi;
        private void FrmÖgrenciSinavModul_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Kuralları: Soru başına 1 dk süreniz olacak. Başarılar Dileriz...");
            lblSoru.Text = soru.ToString();
            btnBitir.Visible = false;
            StartTimer();
            //dataGridView1.DataSource = questionManager.GetQuestionsByNotAnswered(questionDetailManager.GetQuestionsByFalse()); //deneme için
            GenerateQuestions();
            int dogrusorusayisi = GetByQuestionAnswered().Count;
            sorusayisi = 10 + dogrusorusayisi;
            FillTheElements(); //soruüret=1
        }
        private void btnİlerle_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            //QuestionDetailInsert();//öğrenci id sini alsın.
            QuestionDetailUpdate(); //soruyu çözme durumu güncellensin.           
            MessageBox.Show("soru: " + soru + " sorusayisi:" + sorusayisi);
            if (soru == sorusayisi) //10. soruya geldiysek.
            {           
                if (durum == false) //süre devam ediyorsa
                {
                    btnBitir.Visible = true;
                    btnİlerle.Enabled = false;
                }
                //    int sorusayisi = 10 + GetByQuestionAnswered().Count;
                //    if (durum == false)
                //    {
                //        if ((sorusayisi == 10 || 10 + soruüret == sorusayisi))
                //        {
                //            btnBitir.Visible = true;
                //            btnİlerle.Enabled = false;
                //        }
                //        else if (soruüret > 10)
                //        {
                //            sorulistesi.Clear();
                //            soruüret = 0;
                //            sorulistesi = GetByQuestionAnswered();
                //            FillTheElements();
                //        }
                //    }
                //}
            }
            else if (soru == 11)
            {
                MessageBox.Show("soru sayisi 11 oldu : soru üret: " + soruüret);
                sorulistesi.Clear();
                soruüret = 0;
                sorulistesi = GetByQuestionAnswered();
            }
            FillTheElements();
        }
        private bool IsTheQuestionAnsweredCorrectly() //soru doğru mu yanlış mı çözüldü onu kontrol ediyor.
        {
            if (radioButton1.Checked == true)
                return true;
            return false;
        }
        private void QuestionDetailUpdate() //ve her soruda ilgili güncellemeyi yapıyor.ama
        //bu güncellemeyi sorudurum=veritabanından çekilen soruyu doğru bildiği durumu olursa yapmasın.(bu durum ise asd)
        {
            bool sorudurum = IsTheQuestionAnsweredCorrectly();

            questionDetailManager.Update(new QuestionDetail
            {
                QuestionDetailId = questionDetailManager.GetQuestionDetailId(sorulistesi[soruüret - 1].QuestionId, id),
                QuestionId = sorulistesi[soruüret - 1].QuestionId,
                StudentId = id,
                QuestionState = sorudurum,
                AnsweredDate = DateTime.Now
            });
        }
        //private void QuestionDetailInsert()//ve her soruda ilgili detail ekliyor yapıyor.
        //{
        //    int questionId = sorulistesi[soruüret - 1].QuestionId;
        //    int studentId = id;
        //    int questionDetailId = questionDetailManager.GetQuestionDetailId(questionId, studentId);
        //    questionDetailManager.Add(new QuestionDetail { QuestionId = questionId, StudentId = studentId }, questionDetailId);
        //}
        private List<Question> GenerateQuestions() //rastgele soru getirir 10 tane aynı soruyu getirmemesi için ayırdım.
        {
            //int soruadedi = questionManager.GetQuestionsByNotAnswered().Count; //soru sayısı 10 olunca 10 a göre yapılcak. onaylanan soruları getiriyor.
            var questionsfalse = questionDetailManager.GetQuestionsByFalse(id);
            sorulistesi = questionManager.GetQuestionsByNotAnswered(questionsfalse);
            return sorulistesi;
        }
        private List<Question> GetByQuestionAnswered()
        {
            List<QuestionDetail> questionDetails = new List<QuestionDetail>();
            questionDetails = questionDetailManager.GetQuestionsAnsweredByDate(id);
            var questions = questionManager.GetQuestionsByAnswered(questionDetails);
            return questions;
        }
        private void FillTheElements() //rastgele getirilen 10 tane soruyu ilgili toollara doldurur.
        {
            rctxQuestionName.Text = sorulistesi[soruüret].QuestionName;
            pictureBox1.ImageLocation = sorulistesi[soruüret].PicturePath;
            txtSecenekA.Text = sorulistesi[soruüret].QuestionCorrectAnswer;
            txtSecenekB.Text = sorulistesi[soruüret].QuestionWrongAnswer1;
            txtSecenekC.Text = sorulistesi[soruüret].QuestionWrongAnswer2;
            txtSecenekD.Text = sorulistesi[soruüret].QuestionWrongAnswer3;
            soruüret++;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Emin Misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                //QuestionDetailInsert();
                QuestionDetailUpdate();
                MessageBox.Show("Cevaplarınız Gönderildi! Geçmiş Olsun :)...");
                FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
                frmÖgrenci.Show();
                this.Hide();
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
                    durum = true; //süre bitmiştir.
                    MessageBox.Show("Süreniz Bitmiştir. Cevaplarınız Gönderildi. Geçmiş Olsun. :)");
                    FrmÖgrenciAnaSayfa frmÖgrenciAnaSayfa = new FrmÖgrenciAnaSayfa();
                    frmÖgrenciAnaSayfa.Show();
                    this.Hide();
                }
            }
        }
    }
}
