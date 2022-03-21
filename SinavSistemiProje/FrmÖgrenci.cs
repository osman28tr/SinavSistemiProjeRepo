using Business.Concrete;
using DataAccess.Concrete;
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
    public partial class FrmÖgrenci : Form
    {
        public FrmÖgrenci()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttumÖgrenci frmSifremiUnuttumÖgrenci = new FrmSifremiUnuttumÖgrenci();
            frmSifremiUnuttumÖgrenci.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmÖgrenciKayit frmÖgrenciKayit = new FrmÖgrenciKayit();
            frmÖgrenciKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (studentManager.GirisYap(txtMail.Text, txtSifre.Text) == null)
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış Lütfen Tekrar Deneyin");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmÖgrenciSinavModul.id = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciAnaSayfa.ogrid = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciSinavDurum.ogrid = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciAnaSayfa frmÖgrenciAnaSayfa = new FrmÖgrenciAnaSayfa();               
                frmÖgrenciAnaSayfa.Show();
                this.Hide();
            }
        }
    }
}
