using Business.Concrete;
using DataAccess.Concrete;
using Entities;
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
    public partial class FrmAdminKayit : Form
    {
        public FrmAdminKayit()
        {
            InitializeComponent();
        }
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        private void btnAdminKayitOl_Click(object sender, EventArgs e) //adminin kayıt olması
        {
            var failStateString = adminManager.Add(new Admin //validason hatasına bakılır.
            {
                AdminName = txtAdminName.Text,
                AdminSurname = txtAdminSurname.Text,
                AdminMail = txtAdminMail.Text,
                AdminPassword = txtAdminPassword.Text
            });
            if (failStateString != null) //validasyon hatası varsa gösterilir.
            {
                foreach (var item in failStateString)
                {
                    MessageBox.Show(item.ToString());
                }
                failStateString.Clear();
            }
            else //yoksa kayıt edilir, tamamlanma mesajı gösterilir.
                MessageBox.Show("Kayit Başarıyla Tamamlandı");
        }

        private void chbxSifre_CheckedChanged(object sender, EventArgs e) //sifre gizlenmesi,gösterilmesi
        {
            if (chbxSifre.Checked == true)
            {
                txtAdminPassword.UseSystemPasswordChar = false;
                chbxSifre.Text = "Gizle";
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = true;
                chbxSifre.Text = "Göster";
            }
        }
        private void BtnAnasayfa_Click(object sender, EventArgs e) //anasayfaya yönlendirilmesi
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
