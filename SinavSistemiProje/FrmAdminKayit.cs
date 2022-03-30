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
        private void btnAdminKayitOl_Click(object sender, EventArgs e)
        {
            var failstatestring = adminManager.Add(new Admin
            {
                AdminName = txtAdminName.Text,
                AdminSurname = txtAdminSurname.Text,
                AdminMail = txtAdminMail.Text,
                AdminPassword = txtAdminPassword.Text
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
                txtAdminPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
