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
    public class TeacherManager:ITeacherService
    {
        ITeacherDal _teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public Teacher Get()
        {
            return _teacherDal.Get();
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public Teacher GirisYap(string mail, string sifre)
        {
            var teacher = _teacherDal.Get(x => x.TeacherMail == mail && x.TeacherPassword == sifre);
            return teacher;
        }

        public string SifremiGöster(string mail, string name)
        {
            var teacher = _teacherDal.Get(x => x.TeacherMail == mail && x.TeacherName == name);
            if (teacher == null)
                return "Girdiğiniz Bilgiler Yanlış Tekrar Deneyin";
            return "Şifreniz: " + teacher.TeacherPassword.ToString();
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }
    }
}
