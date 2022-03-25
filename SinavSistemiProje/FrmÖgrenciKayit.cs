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
            try
            {
                studentManager.Add(new Student
                {
                    StudentName = txtStudentName.Text,
                    StudentSurname = txtStudentSurname.Text,
                    StudentMail = txtStudentMail.Text,
                    StudentPassword = txtStudentPassword.Text,
                    StudentNo = txtStudentNo.Text
                });
                MessageBox.Show("Kayit İşlemi Başarı ile Tamamlandı");
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
                txtStudentPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtStudentPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
    }
}
