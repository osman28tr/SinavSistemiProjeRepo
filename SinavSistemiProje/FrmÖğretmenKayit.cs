using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
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
    public partial class FrmÖğretmenKayit : Form
    {
        public FrmÖğretmenKayit()
        {
            InitializeComponent();
        }
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        private void btnÖğretmenKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                teacherManager.Add(new Teacher
                {
                    TeacherName = txtTeacherName.Text,
                    TeacherSurname = txtTeacherSurname.Text,
                    TeacherMail = txtTeacherMail.Text,
                    TeacherPassword = txtTeacherPassword.Text,
                    TeacherTel = txtTeacherTel.Text
                });
                MessageBox.Show("Kaydınız Başarılı bir Şekilde Tamamlandı");
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }
    }
}
