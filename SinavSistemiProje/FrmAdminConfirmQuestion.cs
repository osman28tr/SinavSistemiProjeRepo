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
    public partial class FrmAdminConfirmQuestion : Form
    {
        public FrmAdminConfirmQuestion()
        {
            InitializeComponent();
        }
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        int questionState;
        private void FrmAdminConfirmQuestion_Load(object sender, EventArgs e)
        {
            GetQuestions();
        }
        private void GetQuestions()
        {
            DgwSorular.DataSource = questionManager.GetAll();
        }
        private void DgwSorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var row = DgwSorular.CurrentRow;
            //bool durum = false;
            //if ((bool)row.Cells[8].Value == true) {
            //    DialogResult result1 = MessageBox.Show("Soruyu iptal etmek istediğinize emin misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result1 == DialogResult.Yes)
            //    {
            //        UpdateQuestion(durum);
            //        MessageBox.Show("Soru başarıyla iptal edildi");
            //        GetQuestions();
            //    }
            //}
            //else
            //{
            //durum = true;
            var row = DgwSorular.CurrentRow;
            if ((bool)row.Cells[4].Value != true)
            {
                DialogResult result2 = MessageBox.Show("Soruyu onaylamak istediğinize emin misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    UpdateQuestion(/*durum*/);
                    MessageBox.Show("Soru başarıyla onaylandı");
                    GetQuestions();
                }
            }           
            //}

        }
        private void UpdateQuestion(/*bool state*/) //normalizasyon.
        {
            var row = DgwSorular.CurrentRow;
            var questionId = row.Cells[0].Value.ToString();
            questionManager.Update(new Question
            {
                QuestionId = Convert.ToInt32(questionId),
                SubjectId = Convert.ToInt32(row.Cells[1].Value.ToString()),
                QuestionName = row.Cells[2].Value.ToString(),
                PicturePath = row.Cells[3].Value.ToString(),
                ConfirmState = true,
                CreatedDate = questionManager.Get(Convert.ToInt32(questionId)).CreatedDate,
                CorrectAnswer = questionManager.Get(Convert.ToInt32(questionId)).CorrectAnswer
            });
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DgwSorular.DataSource = questionManager.GetConfirmByQuestions();
            questionState = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DgwSorular.DataSource = questionManager.GetNotConfirmByQuestions();
            questionState = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GetQuestions();
            questionState = 0;
        }

        private void txtSoruAdi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoruAdi.Text))
                DgwSorular.DataSource = questionManager.GetQuestionsByQuestionName(txtSoruAdi.Text, questionState);
            else
                DgwSorular.DataSource = questionManager.GetQuestionsByState(questionState);
        }
    }
}
