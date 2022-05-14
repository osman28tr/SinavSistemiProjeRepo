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
    public partial class FrmÖgrenciAnaSayfa : Form
    {
        public FrmÖgrenciAnaSayfa()
        {
            InitializeComponent();
        }
        public static int ogrid = 0;
        StudentManager studentManager = new StudentManager(new EfStudentDal());

        private void FrmÖgrenciAnaSayfa_Load(object sender, EventArgs e)
        {
            GetStudentName(); //ilgili öğrencinin isminin gösterilmesi
            FillTheTool();
        }
        private void FillTheTool() //öğrencinin ilgili verilerinin doldurulması
        {
            var student = studentManager.Get(ogrid);
            txtStudentName.Text = student.StudentName;
            txtStudentSurname.Text = student.StudentSurname;
            txtStudentNo.Text = student.StudentNo;
            txtStudentPassword.Text = student.StudentPassword;
            txtStudentMail.Text = student.StudentMail;
        }
        private void GetStudentName()
        {
            lblOgrenciIsim.Text = "Merhaba " + studentManager.Get(ogrid).StudentName + " Hosgeldin";
        }

        private void btnÖğrenciGüncelle_Click(object sender, EventArgs e)
        {
            studentManager.Update(new Student { StudentId = ogrid, StudentName = txtStudentName.Text, StudentSurname = txtStudentSurname.Text, StudentNo = txtStudentNo.Text, StudentMail = txtStudentMail.Text, StudentPassword = txtStudentPassword.Text });
            MessageBox.Show("Bilgileriniz basarili bir sekilde güncellendi");
        }

        private void chbxSifre_CheckedChanged(object sender, EventArgs e)
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

        private void sınavDurumumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmÖgrenciSinavDurum frmÖgrenciSinavDurum = new FrmÖgrenciSinavDurum();
            frmÖgrenciSinavDurum.Show();
            this.Hide();
        }
    }
}
