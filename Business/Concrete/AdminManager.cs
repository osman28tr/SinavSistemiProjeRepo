using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin Get()
        {
            return _adminDal.Get();
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public string GirisYap(string mail, string sifre)
        {
            var admin = _adminDal.Get(x => x.AdminMail == mail && x.AdminPassword == sifre);
            if (admin == null)
                return "Girdiğiniz Bilgiler Yanlış Lütfen Tekrar Deneyin";
            return "Giriş Başarılı";
        }

        public string SifremiGöster(string mail, string name)
        {
            var admin = _adminDal.Get(x => x.AdminName == name && x.AdminMail == mail);
            if (admin == null)
                return "Girdiğiniz Bilgiler Yanlış Tekrar Deneyin";
            return "Şifreniz: " + admin.AdminPassword.ToString();
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
