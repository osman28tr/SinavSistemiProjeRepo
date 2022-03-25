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
            try
            {
                adminManager.Add(new Admin
                {
                    AdminName = txtAdminName.Text,
                    AdminSurname = txtAdminSurname.Text,
                    AdminMail = txtAdminMail.Text,
                    AdminPassword = txtAdminPassword.Text
                });
                MessageBox.Show("Kayit Başarıyla Tamamlandı");
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
                txtAdminPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
    }
}
