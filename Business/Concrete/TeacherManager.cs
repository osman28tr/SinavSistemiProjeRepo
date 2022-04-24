using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
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
        private static TeacherValidator teacherValidator = new TeacherValidator();
        List<string> validations = new List<string>();
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public List<string> Add(Teacher teacher)
        {
            IList<ValidationFailure> failures = Dogrula(teacher);
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
                _teacherDal.Add(teacher);
                return null;
            }
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public IList<ValidationFailure> Dogrula(Teacher teacher)
        {
            var result = teacherValidator.Validate(teacher);
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

        public Teacher Get(int id)
        {
            return _teacherDal.Get(x => x.TeacherId == id);
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
