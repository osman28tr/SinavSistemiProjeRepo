using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        Teacher Get();
        List<string> Add(Teacher teacher);
        IList<ValidationFailure> Dogrula(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        string SifremiGöster(string mail, string name);
        Teacher GirisYap(string mail, string sifre);
    }
}
