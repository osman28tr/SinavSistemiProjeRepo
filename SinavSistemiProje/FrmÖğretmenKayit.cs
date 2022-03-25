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
            try
            {
                teacherManager.Add(new Teacher
                {
                    TeacherName = txtTeacherName.Text,
                    TeacherSurname = txtTeacherSurname.Text,
                    TeacherMail = txtTeacherMail.Text,
                    TeacherPassword = txtTeacherPassword.Text,
                    TeacherTel = txtTeacherTel.Text
                });
                MessageBox.Show("Kaydınız Başarılı bir Şekilde Tamamlandı");
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTeacherPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtTeacherPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
    }
}
