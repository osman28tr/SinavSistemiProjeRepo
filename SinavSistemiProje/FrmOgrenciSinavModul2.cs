﻿using Business.Concrete;
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
    public partial class FrmOgrenciSinavModul2 : Form
    {
        public FrmOgrenciSinavModul2()
        {
            InitializeComponent();
        }
        public int id = 0;
        int soruüret = 0, soru = 1, saniye = 0, dakika = 0;
        bool durum = false;
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        WrongAnswerManager wrongAnswerManager = new WrongAnswerManager(new EfWrongAnswerDal());
        List<Question> sorulistesi = new List<Question>();
        private void FrmOgrenciSinavModul2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Kuralları: Soru başına 1 dk süreniz olacak. Başarılar Dileriz...");
            lblSoru.Text = soru.ToString();
            btnBitir.Visible = false;
            StartTimer();
            GenerateQuestions();        
            FillTheElements();
        }
        private void FillTheElements()
        {
            rctxQuestionName.Text = sorulistesi[soruüret].QuestionName;
            pcbQuestionİmage.ImageLocation = Application.StartupPath + sorulistesi[soruüret].PicturePath;
            txtSecenekA.Text = sorulistesi[soruüret].CorrectAnswer;
            txtSecenekB.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[0].WrongAnswerName; 
            txtSecenekC.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[1].WrongAnswerName;
            txtSecenekD.Text = wrongAnswerManager.GetAll(sorulistesi[soruüret].QuestionId)[2].WrongAnswerName;
            soruüret++;
        }

        private void btnİlerle_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            if (soru == 10)
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
            var questionsfalse = questionDetailManager.GetQuestionsByFalseAndAnswered(id);
            sorulistesi = questionManager.GetQuestionsByNotAnswered(questionsfalse);
            return sorulistesi;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Emin Misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                timer1.Stop();
                MessageBox.Show("Umarız Hatalarınızı Görüp Ders Çıkarmışsınızdır :)...");
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
                    MessageBox.Show("Süreniz Bitmiştir. Geçmiş Olsun. :)");
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
            MessageBox.Show("Cevap Kağıdınız: 1-A\n2-A\n3-A\n4-A\n5-A\n6-A\n7-A\n8-A\n9-A\n10-A");
        }
    }
}
