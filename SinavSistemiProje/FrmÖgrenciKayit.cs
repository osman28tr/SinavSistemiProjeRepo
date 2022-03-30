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
            var failstatestring = studentManager.Add(new Student
            {
                StudentName = txtStudentName.Text,
                StudentSurname = txtStudentSurname.Text,
                StudentMail = txtStudentMail.Text,
                StudentPassword = txtStudentPassword.Text,
                StudentNo = txtStudentNo.Text
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

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
            frmÖgrenci.Show();
            this.Hide();
        }
    }
}
