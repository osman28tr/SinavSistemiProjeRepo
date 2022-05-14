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
    public partial class FrmÖğretmenKayit : Form
    {
        public FrmÖğretmenKayit()
        {
            InitializeComponent();
        }
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        private void btnÖğretmenKayitOl_Click(object sender, EventArgs e)
        {
            var failStateString = teacherManager.Add(new Teacher //ders sorumlusunun eklenmesi
            {
                TeacherName = txtTeacherName.Text,
                TeacherSurname = txtTeacherSurname.Text,
                TeacherMail = txtTeacherMail.Text,
                TeacherPassword = txtTeacherPassword.Text,
                TeacherTel = txtTeacherTel.Text
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
                txtTeacherPassword.UseSystemPasswordChar = false;
                chbxSifre.Text = "Gizle";
            }
            else
            {
                txtTeacherPassword.UseSystemPasswordChar = true;
                chbxSifre.Text = "Göster";
            }
        }

        private void txtTeacherTel_TextChanged(object sender, EventArgs e) //ders sorumlusuna ait telefon numarası girilirken harf girişinin engellenmesi
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTeacherTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece numara giriniz.");
                txtTeacherTel.Text = txtTeacherTel.Text.Remove(txtTeacherTel.Text.Length - 1);
            }
        }
    }
}
