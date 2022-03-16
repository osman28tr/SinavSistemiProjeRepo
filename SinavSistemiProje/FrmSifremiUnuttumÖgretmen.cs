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
    public partial class FrmSifremiUnuttumÖgretmen : Form
    {
        public FrmSifremiUnuttumÖgretmen()
        {
            InitializeComponent();
        }
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        private void btnSifremiGöster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(teacherManager.SifremiGöster(txtTeacherMail.Text, txtTeacherName.Text));
        }
    }
}
