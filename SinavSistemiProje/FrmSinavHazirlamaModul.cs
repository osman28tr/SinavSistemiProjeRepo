﻿using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemiProje
{
    public partial class FrmSinavHazirlamaModul : Form
    {
        public FrmSinavHazirlamaModul()
        {
            InitializeComponent();
        }
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        QuestionDetailManager questionDetailManager = new QuestionDetailManager(new EfQuestionDetailDal());
        LessonManager lessonManager = new LessonManager(new EfLessonDal());
        UnitManager unitManager = new UnitManager(new EfUnitDal());
        SubjectManager subjectManager = new SubjectManager(new EfSubjectDal());
        WrongAnswerManager wrongAnswerManager = new WrongAnswerManager(new EfWrongAnswerDal());
        SigmaManager sigmaManager = new SigmaManager(new EfSigmaDal());
        string DosyaYolu = "";
        string correctAnswer = "";
        string[] WrongAnswer = new string[3];
        int lastQuestionId;
        private void FrmSinavHazirlamaModul_Load(object sender, EventArgs e)
        {
            //form ilk yüklendiğinde ilgili comboboxlara verilerin eklenmesi
            LoadLessons();
            LoadUnits(1);
            LoadSubjects(1);
            LoadStudents();
            FillSigma();
        }
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyasi |*.jpg;*.png|Tüm Dosyalar|*.*";
            dosya.Title = "Sinav Hazırlama Modülü Dosya Seçimi";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            pcbQuestionİmage.ImageLocation = DosyaYolu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CheckedState();
            Random rastgele = new Random();
            int sayi = rastgele.Next(10, 1000000);
            //soru resminin images klasörüne eklenmesi eklenmesi
            string imagefile = Path.GetFileName(pcbQuestionİmage.ImageLocation);
            string imagepath = Path.Combine(Application.StartupPath + "\\images\\" + sayi + imagefile);
            string imagename = Path.Combine("\\images\\" + sayi + imagefile);
            if (imagefile == null)
                imagename = null;
            //sorunun veritabanına eklenmesi
            var failstatestring = questionManager.Add(new Question 
            {
                QuestionName = rctxQuestionName.Text,
                SubjectId = (int)cmbSubject.SelectedValue,
                CreatedDate = DateTime.Now,
                PicturePath = imagename,
                CorrectAnswer = correctAnswer
            });
            if (failstatestring != null) //eğer validasyon hatası alındıysa o hataların gösterilmesi
            {
                foreach (var item in failstatestring)
                {
                    MessageBox.Show(item.ToString());
                }
                failstatestring.Clear();
            }
            else //alınmadıysa ilgili soruya ait detail ve wrongAnswer'ın eklenmesi
            {
                if (imagename != null)
                    File.Copy(pcbQuestionİmage.ImageLocation, imagepath);
                QuestionDetailAdd();
                WrongAnswerAdd();
                MessageBox.Show("Hazırladığınız soru admine başarıyla gönderildi!");
                ToolsClear();
            }
        }
        private void ToolsClear() //soru eklendikten sonra toolboxların temizlenmesi
        {
            rctxQuestionName.Clear();
            pcbQuestionİmage.Image = null;
            txtSecenekA.Clear();
            txtSecenekB.Clear();
            txtSecenekC.Clear();
            txtSecenekD.Clear();
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
        private void QuestionDetailAdd() //ilgili soruya ait detail'in eklenmesi
        {      
            lastQuestionId = questionManager.GetLastQuestionId();
            if (chbxHerkes.Checked == true)
            {
                int studentCount = studentManager.GetAll().Count;
                List<Student> students = studentManager.GetAll();
                for (int i = 0; i < studentCount; i++)
                {
                    questionDetailManager.Add(new QuestionDetail { QuestionId = lastQuestionId, StudentId = students[i].StudentId, SigmaCount = 0, QuestionState = false, AnsweredState = false });
                }
            }
            else
                questionDetailManager.Add(new QuestionDetail { QuestionId = lastQuestionId, StudentId = (int)cmbStudents.SelectedValue, SigmaCount = 0, QuestionState = false, AnsweredState = false });
        }
        private void WrongAnswerAdd() //ilgili soruya ait yanlış cevapların eklenmesi
        {
            for (int i = 0; i < 3; i++)
            {
                wrongAnswerManager.Add(new WrongAnswer
                {
                    WrongAnswerName = WrongAnswer[i],
                    QuestionId = lastQuestionId
                });
            }
        }
        private void CheckedState() //soruya ait doğru-yanlış cevap kontrolünün yapılması
        {
            if (rdbA.Checked == true)
            {
                correctAnswer = txtSecenekA.Text;
                WrongAnswer[0] = txtSecenekB.Text;
                WrongAnswer[1] = txtSecenekC.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else if (rdbB.Checked == true)
            {
                correctAnswer = txtSecenekB.Text;
                WrongAnswer[0] = txtSecenekA.Text;
                WrongAnswer[1] = txtSecenekC.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else if (rdbC.Checked == true)
            {
                correctAnswer = txtSecenekC.Text;
                WrongAnswer[0] = txtSecenekA.Text;
                WrongAnswer[1] = txtSecenekB.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else
            {
                correctAnswer = txtSecenekD.Text;
                WrongAnswer[0] = txtSecenekA.Text;
                WrongAnswer[1] = txtSecenekC.Text;
                WrongAnswer[2] = txtSecenekB.Text;
            }
        }
        private void LoadLessons()
        {
            cmbLesson.DataSource = lessonManager.GetAll();
            cmbLesson.DisplayMember = "LessonName";
            cmbLesson.ValueMember = "LessonId";
        }
        private void LoadUnits(int a)
        {
            cmbUnit.DataSource = unitManager.GetAllById(a);
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitId";
        }
        private void LoadSubjects(int a)
        {
            cmbSubject.DataSource = subjectManager.GetAllById(a);
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
        }
        private void LoadStudents()
        {
            cmbStudents.DataSource = studentManager.GetAll();
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";
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
        private void cmbLesson_SelectionChangeCommitted(object sender, EventArgs e) //ilgili ders seçildikten sonra derse ait ünitelerin ilgili combobox'a eklenmesi
        {
            try
            {
                int chosenLesson = (int)(cmbLesson.SelectedValue);
                cmbUnit.DataSource = unitManager.GetUnitsByLesson(chosenLesson);
                cmbUnit.DisplayMember = "UnitName";
                cmbUnit.ValueMember = "UnitId";
                cmbLesson.SelectionChangeCommitted += cmbUnit_SelectionChangeCommitted;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbUnit_SelectionChangeCommitted(object sender, EventArgs e) //ilgili ünite seçildikten sonra üniteye ait konuların ilgili combobox'a eklenmesi
        {
            try
            {
                int chosenUnit = (int)(cmbUnit.SelectedValue);
                cmbSubject.DataSource = subjectManager.GetSubjectsByUnit(chosenUnit);
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectId";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
        private void btnUygula_Click(object sender, EventArgs e) //sorulara ait sigmanın ayarlanması
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

        private void chbxHerkes_CheckedChanged(object sender, EventArgs e)
        {
            cmbStudents.Enabled = false;
            if (chbxHerkes.Checked == false)
                cmbStudents.Enabled = true;
        }
    }
}
