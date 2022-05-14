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
    public partial class FrmÖgrenciKayit : Form
    {
        public FrmÖgrenciKayit()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private void btnÖğrenciKayitOl_Click(object sender, EventArgs e)
        {
            var failStateString = studentManager.Add(new Student //öğrencinin eklenmesi
            {
                StudentName = txtStudentName.Text,
                StudentSurname = txtStudentSurname.Text,
                StudentMail = txtStudentMail.Text,
                StudentPassword = txtStudentPassword.Text,
                StudentNo = txtStudentNo.Text
            });
            if (failStateString != null) //validasyon kontrolünde bir hata oluştuysa o hataların gösterilmesi
            {
                foreach (var item in failStateString)
                {
                    MessageBox.Show(item.ToString());
                }
                failStateString.Clear();
            }
            else //validasyon hatası yoksa ekleme işleminin başarılı bir şekilde gerçekleştiğine dair mesajın gösterilmesi
                MessageBox.Show("Kayit Başarıyla Tamamlandı");
        }

        private void chbxSifre_CheckedChanged(object sender, EventArgs e) //şifre gizleme,gösterme
        {
            if (chbxSifre.Checked == true)
            {
                txtStudentPassword.UseSystemPasswordChar = false;
                chbxSifre.Text = "Gizle";
            }
            else
            {
                txtStudentPassword.UseSystemPasswordChar = true;
                chbxSifre.Text = "Göster";
            }
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
            frmÖgrenci.Show();
            this.Hide();
        }
    }
}
