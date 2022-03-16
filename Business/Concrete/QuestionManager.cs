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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;
        Random random = new Random();
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public void Delete(Question question)
        {
            _questionDal.Delete(question);
        }

        public Question Get()
        {
            return _questionDal.Get();
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetAll();
        }

        public List<Question> GetQuestionsByNotAnswered()
        {
            int[] dizi2 = GenerateRandomNumber();
            //int questionmenstruation = _questionDal.GetAll().Count;
            //int[] dizi = new int[questionmenstruation];
            List<Question> questions = new List<Question>();
            for (int i = 0; i < 10; i++) //soru sayısı 10 olunca 10 a göre yapılcak
            {
                //int a = random.Next(1, questionmenstruation + 1);
                //if (dizi.Contains(a))
                //{
                //    i--;
                //    continue;
                //}                    
                //dizi[i] = a;
                int a = dizi2[i];
                questions.Add(_questionDal.Get(x => x.QuestionId == a));
            }
            return questions;
        }
        private int[] GenerateRandomNumber()
        {
            int questionmenstruation = _questionDal.GetAll().Count;
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(1, questionmenstruation + 1);
                if (dizi.Contains(a))
                {
                    i--;
                    continue;
                }
                dizi[i] = a;
            }
            return dizi;
        }
        public void Update(Question question)
        {
            _questionDal.Update(question);
        }
    }
}
