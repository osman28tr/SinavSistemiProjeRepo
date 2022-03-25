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
    public class StudentManager:IStudentService
    {
        IStudentDal _studentDal;
        private static StudentValidator studentValidator = new StudentValidator();
        List<string> validations = new List<string>();
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public List<string> Add(Student student)
        {
            IList<ValidationFailure> failures = Dogrula(student);
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
                _studentDal.Add(student);
                return null;
            }
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public IList<ValidationFailure> Dogrula(Student student)
        {
            var result = studentValidator.Validate(student);
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

        public Student Get(int id)
        {
            return _studentDal.Get(x => x.StudentId == id);
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
