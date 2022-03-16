using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager:IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student Get()
        {
            return _studentDal.Get();
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public int GetStudentId(string mail)
        {
            return _studentDal.Get(x => x.StudentMail == mail).StudentId;
        }

        public Student GirisYap(string mail, string sifre)
        {
            var student = _studentDal.Get(x => x.StudentMail == mail && x.StudentPassword == sifre);
            return student;
        }

        public string SifremiGöster(string mail, string name)
        {
            var student = _studentDal.Get(x => x.StudentMail == mail && x.StudentName == name);
            if (student == null)
                return "Girdiğiniz Bilgiler Yanlış Tekrar Deneyin";
            return "Şifreniz: " + student.StudentPassword.ToString();
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
