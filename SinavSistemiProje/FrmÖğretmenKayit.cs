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
            var failstatestring = teacherManager.Add(new Teacher
            {
                TeacherName = txtTeacherName.Text,
                TeacherSurname = txtTeacherSurname.Text,
                TeacherMail = txtTeacherMail.Text,
                TeacherPassword = txtTeacherPassword.Text,
                TeacherTel = txtTeacherTel.Text
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
                MessageBox.Show("Kayit Başarıyla Tamamlandı");
        }

        private void chbxSifre_CheckedChanged(object sender, EventArgs e)
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

        private void txtTeacherTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTeacherTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece numara giriniz.");
                txtTeacherTel.Text = txtTeacherTel.Text.Remove(txtTeacherTel.Text.Length - 1);
            }
        }
    }
}
