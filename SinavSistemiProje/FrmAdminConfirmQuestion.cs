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
        private void FrmAdminConfirmQuestion_Load(object sender, EventArgs e)
        {
            GetQuestions();
        }

        private void DgwSorular_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
                DialogResult result2 = MessageBox.Show("Soruyu onaylamak istediğinize emin misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    UpdateQuestion(/*durum*/);
                    MessageBox.Show("Soru başarıyla onaylandı");
                    GetQuestions();
                }
            //}
                            
        }
        private void UpdateQuestion(/*bool state*/)
        {
            var row = DgwSorular.CurrentRow;
            questionManager.Update(new Question
            {
                QuestionId = Convert.ToInt32(row.Cells[0].Value.ToString()),
                SubjectId = Convert.ToInt32(row.Cells[1].Value.ToString()),
                QuestionName = row.Cells[2].Value.ToString(),
                PicturePath = row.Cells[3].Value.ToString(),
                QuestionCorrectAnswer = row.Cells[4].Value.ToString(),
                QuestionWrongAnswer1 = row.Cells[5].Value.ToString(),
                QuestionWrongAnswer2 = row.Cells[6].Value.ToString(),
                QuestionWrongAnswer3 = row.Cells[7].Value.ToString(),
                ConfirmState = true
            });
        }
    }
}
