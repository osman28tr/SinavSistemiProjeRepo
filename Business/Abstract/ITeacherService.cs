using Entities.Concrete;
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
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        string SifremiGöster(string mail, string name);
        Teacher GirisYap(string mail, string sifre);
    }
}
