using Business.Abstract;
using Business.ValidationRules.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities;
using FluentValidation;
using FluentValidation.Results;
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
        private static AdminValidator adminValidator = new AdminValidator();
        List<string> validations = new List<string>();
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public List<string> Add(Admin admin)
        {
            IList<ValidationFailure> failures = Dogrula(admin);
            if (failures != null)
            {
                foreach (var failure in failures)
                {
                    validations.Add(failure.ErrorMessage);
                }
                return validations;
            }
            else
            {
                _adminDal.Add(admin);
                return null;
            }
        }
        public IList<ValidationFailure> Dogrula(Admin admin)
        {
            var result = adminValidator.Validate(admin);
            IList<ValidationFailure> failures = result.Errors;
            if (!result.IsValid)
            {
                return failures;
            }
            else
            {
                return null;
            }

        }
        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin Get(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin GirisYap(string mail, string sifre)
        {
            var admin = _adminDal.Get(x => x.AdminMail == mail && x.AdminPassword == sifre);
            return admin;
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
