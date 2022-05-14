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
        private void btnSifremiUnuttum_Click(object sender, EventArgs e) //şifremi unuttum ekranı yönlendirme işlemi
        {
            FrmSifremiUnuttumÖgrenci frmSifremiUnuttumÖgrenci = new FrmSifremiUnuttumÖgrenci();
            frmSifremiUnuttumÖgrenci.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)//kayıt olma ekranı yönlendirme işlemi
        {
            FrmÖgrenciKayit frmÖgrenciKayit = new FrmÖgrenciKayit();
            frmÖgrenciKayit.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (studentManager.GirisYap(txtMail.Text, txtSifre.Text) == null) //ilgili öğrenciye ait mail ve sifrenin kontrol edilmesi
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış Lütfen Tekrar Deneyin");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmÖgrenciSinavModul.ogrid = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciAnaSayfa.ogrid = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciSinavDurum.ogrid = studentManager.GetStudentId(txtMail.Text);
                FrmÖgrenciAnaSayfa frmÖgrenciAnaSayfa = new FrmÖgrenciAnaSayfa();
                frmÖgrenciAnaSayfa.Show();
                this.Hide();
            }
        }
        private void chbxSifre_CheckedChanged(object sender, EventArgs e) //şifre gizlenmesi,gösterilmesi
        {
            if (chbxSifre.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                chbxSifre.Text = "Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                chbxSifre.Text = "Göster";
            }
        }
    }
}
