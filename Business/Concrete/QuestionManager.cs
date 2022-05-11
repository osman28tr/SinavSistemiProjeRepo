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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;
        private static QuestionValidator questionValidator = new QuestionValidator();
        List<string> validations = new List<string>();
        Random random = new Random();
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public List<string> Add(Question question)
        {
            IList<ValidationFailure> failures = Dogrula(question);
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
                _questionDal.Add(question);
                return null;
            }
        }
        public IList<ValidationFailure> Dogrula(Question question) //soru ekleme modülünde ilgili validasyonların yapılması
        {
            var result = questionValidator.Validate(question);
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
        public void Delete(Question question)
        {
            _questionDal.Delete(question);
        }

        public Question Get(int id)
        {
            return _questionDal.Get(x => x.QuestionId == id);
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetAll();
        }

        public List<Question> GetQuestionsByNotAnswered(List<QuestionDetail> questionDetails) //çözülmemiş ve çözme durumu false olanlar üzerinden student id ye göre rastgele sorular üretiliyor.
        {
            int[] dizi2 = GenerateRandomNumber(questionDetails); //rastgele question id ler üretildi.
            List<Question> questions = new List<Question>();
            for (int i = 0; i < 10; i++) 
            {
                int questionid = dizi2[i];               
                questions.Add(_questionDal.Get(x => x.QuestionId == questionid)); 
            }
            return questions;
        }
        private int[] GenerateRandomNumber(List<QuestionDetail> questionDetails) 
        {
            bool durum = true;
            int count = questionDetails.Count; 
            int[] dizi = new int[10]; 
            int[] dizi2 = new int[10]; 
            for (int i = 0; i < 10; i++) 
            {
                int randomnumberindex = random.Next(0, count); 
                for (int j = 0; j < i; j++) 
                {
                    if (dizi[j] == randomnumberindex) 
                    {
                        durum = false;
                        break;
                    }
                    else
                    {
                        durum = true;
                    }
                }
                if (durum == true) 
                {
                    dizi[i] = randomnumberindex;
                    dizi2[i] = questionDetails[randomnumberindex].QuestionId;
                }
                else 
                {
                    i--;
                    continue;
                }
            }
            return dizi2;
        }
        public void Update(Question question)
        {
            _questionDal.Update(question);
        }

        public List<Question> GetQuestionsByAnswered(List<QuestionDetail> questionDetails)
        {
            int valuecount = questionDetails.Count;
            var questiondetail = questionDetails.Select(x => x.QuestionId).ToList();
            List<Question> questions = new List<Question>();
            for (int i = 0; i < valuecount; i++)
            {
                int questionid = questiondetail[i];
                questions.Add(_questionDal.Get(x => x.QuestionId == questionid));
            }
            return questions;
        }

        public int GetLastQuestionId() //son eklenilen sorunun id sini veriyor.
        {
            return _questionDal.GetAll().LastOrDefault().QuestionId;
        }

        public List<Question> GetConfirmByQuestions() //admin tarafından onaylanan sorular getiriliyor.
        {
            return _questionDal.GetAll(x => x.ConfirmState == true);
        }

        public List<Question> GetNotConfirmByQuestions()
        {
            return _questionDal.GetAll(x => x.ConfirmState == false);
        }

        public List<Question> GetQuestionsByQuestionName(string questionName, int questionConfirmState)
        {
            if (questionConfirmState == 0)
                return _questionDal.GetAll(x => x.QuestionName.ToLower().Contains(questionName.ToLower()));
            else if (questionConfirmState == 1)
                return _questionDal.GetAll(x => x.QuestionName.ToLower().Contains(questionName.ToLower()) && x.ConfirmState == false);
            else
                return _questionDal.GetAll(x => x.QuestionName.ToLower().Contains(questionName.ToLower()) && x.ConfirmState == true);
        }

        public List<Question> GetQuestionsByState(int state)
        {
            if (state == 1)
                return GetNotConfirmByQuestions();
            else if (state == 0)
                return GetAll();
            else
                return GetConfirmByQuestions();
        }

        public int QuestionBySubject(int subjectId) //ilgili konuya ait soruların sayısını veriyor.
        {
            return _questionDal.GetAll(x => x.SubjectId == subjectId).Count;
        }
    }
}
