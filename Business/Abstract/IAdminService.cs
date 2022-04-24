using Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        Admin Get(int id);
        List<string> Add(Admin admin);
        IList<ValidationFailure> Dogrula(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        string SifremiGöster(string mail, string name);
        Admin GirisYap(string mail, string sifre);
    }
}
