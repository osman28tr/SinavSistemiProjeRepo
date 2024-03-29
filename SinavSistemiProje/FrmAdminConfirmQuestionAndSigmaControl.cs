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
    public partial class FrmAdminConfirmQuestionAndSigmaControl : Form
    {
        public FrmAdminConfirmQuestionAndSigmaControl()
        {
            InitializeComponent();
        }
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        SigmaManager sigmaManager = new SigmaManager(new EfSigmaDal());
        private void FrmAdminConfirmQuestion_Load(object sender, EventArgs e)
        {
            GetQuestions(); //soruların datagridview'e doldurulması
            FillSigma(); //sigma ayarlanması için ilgili combobox'a verilerin doldurulması
        }
        private void GetQuestions()
        {
            DgwSorular.DataSource = questionManager.GetAll();
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
        private void DgwSorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //datagridview'de ilgili soruya çift tıklanınca eğer soru onaylı değilse onaylanma işlemi yapılır.
        {
            var row = DgwSorular.CurrentRow;
            if ((bool)row.Cells[4].Value != true)
            {
                DialogResult result2 = MessageBox.Show("Soruyu onaylamak istediğinize emin misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    UpdateQuestion(); //onaylama işleminin yapılması
                    MessageBox.Show("Soru başarıyla onaylandı");
                    GetQuestions(); //tekrardan soruların datagridview'e güncellenmiş şekilde yüklenmesi
                }
            }           
        }
        private void UpdateQuestion() //ilgili sorunun onaylanması
        {
            var row = DgwSorular.CurrentRow;
            var questionId = row.Cells[0].Value.ToString(); //soruya ait id'sinin alınması
            questionManager.Update(new Question //ve id'ye göre güncellenmesi
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

        private void rbConfirm_CheckedChanged(object sender, EventArgs e) //onaylanan soruların gösterilmesi
        {
            DgwSorular.DataSource = questionManager.GetConfirmByQuestions();
        }

        private void rbNotConfirm_CheckedChanged(object sender, EventArgs e) //onaylanmayan soruların gösterilmesi
        {
            DgwSorular.DataSource = questionManager.GetNotConfirmByQuestions();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)//tüm soruların gösterilmesi
        {
            GetQuestions();
        }

        private void btnUygula_Click(object sender, EventArgs e) //6 sigma yaklaşımının ayarlanması
        {
            if (sigmaManager.GetAll().Count > 0) //sigma tabosunda kayıt varmı diye bakılır. varsa güncellenir yoksa eklenir.
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
    }
}
