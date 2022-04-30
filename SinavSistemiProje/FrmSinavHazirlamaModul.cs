using Business.Concrete;
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
        //CorrectAnswerManager correctAnswerManager = new CorrectAnswerManager(new EfCorrectAnswerDal());
        string DosyaYolu = "";
        string correctAnswer = "";
        string[] WrongAnswer = new string[3];
        int lastQuestionId; //normalizasyon
        private void FrmSinavHazirlamaModul_Load(object sender, EventArgs e)
        {
            LoadLessons();
            LoadUnits(1);
            LoadSubjects(1);
            LoadStudents();
            FillSigma();
            //cmbLesson.SelectedIndex = 1;
            //cmbUnit.DataSource = unitManager.GetUnitsByLesson(a);
            //cmbUnit.DisplayMember = "UnitName";
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

            string imagefile = Path.GetFileName(pcbQuestionİmage.ImageLocation);
            string imagepath = Path.Combine(Application.StartupPath + "\\images\\" + sayi + imagefile);
            string imagename = Path.Combine("\\images\\" + sayi + imagefile);
            //File.Copy(pictureBox1.ImageLocation, imagepath);
            if (imagefile == null)
                imagename = null;

            var failstatestring = questionManager.Add(new Question
            {
                QuestionName = rctxQuestionName.Text,
                SubjectId = (int)cmbSubject.SelectedValue,
                CreatedDate = DateTime.Now,
                PicturePath = imagename,
                CorrectAnswer = correctAnswer
            });
            if (failstatestring != null)
            {
                foreach (var item in failstatestring)
                {
                    MessageBox.Show(item.ToString());
                }
                failstatestring.Clear();
            }
            else
            {
                if (imagename != null)
                    File.Copy(pcbQuestionİmage.ImageLocation, imagepath);
                QuestionDetailAdd();
                //CorrectAnswerAdd();//normalizasyon
                WrongAnswerAdd();//normalizasyon
                MessageBox.Show("Hazırladığınız soru admine başarıyla gönderildi!");
                ToolsClear();
            }
            //questionManager.Add(new Question
            //{
            //    QuestionName = rctxQuestionName.Text,
            //    PicturePath = imagename,
            //    //QuestionCorrectAnswer = CorrectAnswer,
            //    //QuestionWrongAnswer1 = WrongAnswer[0],
            //    //QuestionWrongAnswer2 = WrongAnswer[1],
            //    //QuestionWrongAnswer3 = WrongAnswer[2],
            //    SubjectId = (int)cmbSubject.SelectedValue,
            //});
            //QuestionDetailAdd();
            //CorrectAnswerAdd();//normalizasyon
            //WrongAnswerAdd();//normalizasyon
            //MessageBox.Show("Hazırladığınız soru admine başarıyla gönderildi!");
        }
        private void ToolsClear()
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
        private void QuestionDetailAdd()
        {
            //id = questionManager.GetAll().LastOrDefault().QuestionId;            
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
        private void CorrectAnswerAdd()
        {
            //correctAnswerManager.Add(new CorrectAnswer
            //{
            //    CorrectAnswerName = CorrectAnswer,
            //    QuestionId = id
            //});



            //var failstatestring = correctAnswerManager.Add(new CorrectAnswer
            //{
            //    CorrectAnswerName = CorrectAnswer,
            //    QuestionId = id
            //});
            //if (failstatestring != null)
            //{
            //    correctAnswerFailState = true;
            //    foreach (var item in failstatestring)
            //    {
            //        MessageBox.Show(item.ToString());
            //    }
            //    failstatestring.Clear();
            //}
            //else
            //    correctAnswerFailState = false;
        }
        private void WrongAnswerAdd()
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    wrongAnswerManager.Add(new WrongAnswer
            //    {
            //        WrongAnswerName = WrongAnswer[i],
            //        QuestionId = id
            //    });
            //}
            for (int i = 0; i < 3; i++)
            {
                wrongAnswerManager.Add(new WrongAnswer
                {
                    WrongAnswerName = WrongAnswer[i],
                    QuestionId = lastQuestionId
                });
            }
        }
        private void CheckedState()
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
        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //string a = cmbLesson.SelectedValue.ToString();
            //    int a = (int)(cmbLesson.SelectedValue);
            //    cmbUnit.DataSource = unitManager.GetUnitsByLesson(a);
            //    cmbUnit.DisplayMember = "UnitName";
            //    cmbUnit.ValueMember = "UnitId";
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

        }
        private void LoadStudents()
        {
            cmbStudents.DataSource = studentManager.GetAll();
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";
        }
        private void SubjectsByUnit(int id)
        {
            cmbSubject.DataSource = subjectManager.GetSubjectsByUnit(id);
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
        }
        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //string a = cmbLesson.SelectedValue.ToString();
            //    int a = (int)(cmbUnit.SelectedValue);
            //    cmbSubject.DataSource = subjectManager.GetSubjectsByUnit(a);
            //    cmbSubject.DisplayMember = "SubjectName";
            //    cmbSubject.ValueMember = "SubjectId";
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
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
        private void cmbLesson_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //string a = cmbLesson.SelectedValue.ToString();
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

        private void cmbUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //string a = cmbLesson.SelectedValue.ToString();
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
        private void btnUygula_Click(object sender, EventArgs e)
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
