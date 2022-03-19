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
        string DosyaYolu = "";
        string CorrectAnswer = "";
        string[] WrongAnswer = new string[3];
        private void FrmSinavHazirlamaModul_Load(object sender, EventArgs e)
        {
            LoadLessons();
            LoadUnits(1);
            LoadSubjects(1);
            LoadStudents();
            MessageBox.Show(Convert.ToInt32(cmbLesson.SelectedValue).ToString());
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
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CheckedState();
            questionManager.Add(new Question
            {
                QuestionName = rctxQuestionName.Text,
                PicturePath = DosyaYolu,
                QuestionCorrectAnswer = CorrectAnswer,
                QuestionWrongAnswer1 = WrongAnswer[0],
                QuestionWrongAnswer2 = WrongAnswer[1],
                QuestionWrongAnswer3 = WrongAnswer[2],
                SubjectId = (int)cmbSubject.SelectedValue,
            });
            QuestionDetailAdd();
            MessageBox.Show("Hazırladığınız soru admine başarıyla gönderildi!");
        }
        private void QuestionDetailAdd()
        {
            int id = questionManager.GetAll().LastOrDefault().QuestionId;
            questionDetailManager.Add(new QuestionDetail { QuestionId = id, StudentId = (int)cmbStudents.SelectedValue, SigmaCount = 0, AnsweredDate = DateTime.Now, QuestionState = false });
        }
        private void CheckedState()
        {
            if (radioButton1.Checked == true)
            {
                CorrectAnswer = txtSecenekA.Text;
                WrongAnswer[0] = txtSecenekB.Text;
                WrongAnswer[1] = txtSecenekC.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else if (radioButton2.Checked == true)
            {
                CorrectAnswer = txtSecenekB.Text;
                WrongAnswer[0] = txtSecenekA.Text;
                WrongAnswer[1] = txtSecenekC.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else if (radioButton3.Checked == true)
            {
                CorrectAnswer = txtSecenekC.Text;
                WrongAnswer[0] = txtSecenekA.Text;
                WrongAnswer[1] = txtSecenekB.Text;
                WrongAnswer[2] = txtSecenekD.Text;
            }
            else
            {
                CorrectAnswer = txtSecenekD.Text;
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

        private void cmbLesson_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //string a = cmbLesson.SelectedValue.ToString();
                int a = (int)(cmbLesson.SelectedValue);
                cmbUnit.DataSource = unitManager.GetUnitsByLesson(a);
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
                int a = (int)(cmbUnit.SelectedValue);
                cmbSubject.DataSource = subjectManager.GetSubjectsByUnit(a);
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectId";
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
