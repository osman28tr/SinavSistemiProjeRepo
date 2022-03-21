using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student Get(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
        int GetStudentId(string mail);
        string SifremiGöster(string mail, string name);
        Student GirisYap(string mail, string sifre);
    }
}
