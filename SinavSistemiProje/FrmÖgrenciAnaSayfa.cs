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
    public partial class FrmÖgrenciAnaSayfa : Form
    {
        public FrmÖgrenciAnaSayfa()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private void FrmÖgrenciAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        private void LoadStudentKnow()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hazır mısınız?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                FrmÖgrenciSinavModul frmÖgrenciSinavModul = new FrmÖgrenciSinavModul();
                frmÖgrenciSinavModul.Show();
                this.Hide();

            }

        }
    }
}
