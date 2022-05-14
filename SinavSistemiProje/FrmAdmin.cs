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
    public partial class FrmAdmin:Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        private void btnKayitOl_Click(object sender, EventArgs e) //kayıt işlemi için ilgili forma yönlendirilmesi
        {
            FrmAdminKayit frmAdminKayit = new FrmAdminKayit();
            frmAdminKayit.Show();
            this.Hide();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e) //şifremi unuttum işlemi için ilgili forma yönlendirilmesi
        {
            FrmSifremiUnuttumAdmin frmSifremiUnuttumAdmin = new FrmSifremiUnuttumAdmin();
            frmSifremiUnuttumAdmin.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e) //giriş için ilgili kontrollerin yapılması
        {
            if (adminManager.GirisYap(txtMail.Text, txtSifre.Text) == null)
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış Lütfen Tekrar Deneyin");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmAdminConfirmQuestionAndSigmaControl frmAdminConfirmQuestion = new FrmAdminConfirmQuestionAndSigmaControl();
                frmAdminConfirmQuestion.Show();
                this.Hide();
            }
        }
        private void chbxSifre_CheckedChanged(object sender, EventArgs e) //şifre gizleme,gösterme
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
