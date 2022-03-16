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
    public partial class FrmSifremiUnuttumAdmin : Form
    {
        public FrmSifremiUnuttumAdmin()
        {
            InitializeComponent();
        }
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        private void btnSifremiGöster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(adminManager.SifremiGöster(txtAdminMail.Text, txtAdminName.Text));
        }
    }
}
