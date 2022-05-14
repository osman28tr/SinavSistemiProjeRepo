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
    public partial class FrmÖğretmen : Form
    {
        public FrmÖğretmen()
        {
            InitializeComponent();
        }
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        private void btnSifremiUnuttum_Click(object sender, EventArgs e) //şifremi unuttum formu için yönlendirme işlemi
        {
            FrmSifremiUnuttumÖgretmen frmSifremiUnuttumÖgretmen = new FrmSifremiUnuttumÖgretmen();
            frmSifremiUnuttumÖgretmen.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e) //kayıt olma için ilgili forma yönlendirme işlemi
        {
            FrmÖğretmenKayit frmÖğretmenKayit = new FrmÖğretmenKayit();
            frmÖğretmenKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (teacherManager.GirisYap(txtMail.Text, txtSifre.Text) == null) //sınav sorumlusuna ait mail ve sifre kontrollerinin yapılması
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış Lütfen Tekrar Deneyin");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmSinavHazirlamaModul frmSinavHazirlamaModul = new FrmSinavHazirlamaModul();
                frmSinavHazirlamaModul.Show();
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
