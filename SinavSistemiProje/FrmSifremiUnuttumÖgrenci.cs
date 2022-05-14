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
    public partial class FrmSifremiUnuttumÖgrenci : Form
    {
        public FrmSifremiUnuttumÖgrenci()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private void btnSifremiGöster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(studentManager.SifremiGöster(txtStudentMail.Text, txtStudentName.Text)); //ilgili öğrenciye ait şifrenin verilmesi
        }
    }
}
