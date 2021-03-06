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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private void BtnAdmin_Click(object sender, EventArgs e) //admin girişi
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }
        private void btnOgrenci_Click(object sender, EventArgs e) //öğrenci girişi
        {
            FrmÖgrenci frmÖgrenci = new FrmÖgrenci();
            frmÖgrenci.Show();
            this.Hide();
        }

        private void btnOgretmen_Click(object sender, EventArgs e) //sınav sorumlusu girişi
        {
            FrmÖğretmen frmÖğretmen = new FrmÖğretmen();
            frmÖğretmen.Show();
            this.Hide();
        }
    }
}
