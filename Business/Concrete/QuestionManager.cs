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

        public List<Question> GetQuestionsByNotAnswered(List<QuestionDetail> questionDetails)//çözme durumu false olanlar üzerinden ve student id ye göre rastgele sorular üretildi.
        {
            int[] dizi2 = GenerateRandomNumber(questionDetails); //question id leri rastgele verildi.
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
                //if (questionDetails.Find(x => x.QuestionId == a) != null) //question'ları false olanları getirsin. ve benim ürettiğim rastgele bir id nin durumu false ise getirsin.
                //{
                //    questions.Add(_questionDal.Get(x => x.QuestionId == a));
                //}
                //else
                //{

                //}
                questions.Add(_questionDal.Get(x => x.QuestionId == a)); // normal hali.
            }
            return questions;
        }
        private int[] GenerateRandomNumber(List<QuestionDetail> questionDetails) //çözme durumu false olanlar geliyor.
        {
            bool durum = true;
            //int questionmenstruationmax = questionDetails.Max(x => x.QuestionId);
            //int questionmenstruationmin = questionDetails.Min(x => x.QuestionId);
            int count = questionDetails.Count; //bize gelen doğru çözme durumu false olan soruların sayısını aldık
            int[] dizi = new int[10]; //sayıların aynı olmaması için.
            int[] dizi2 = new int[10]; //bizim durumu false olanların questionid'lerini ilgili diziye atmak için
            for (int i = 0; i < 10; i++) //count olan yer normalde 10 dur.(confirmstate'e göre ayarladım.)
            {
                int a = random.Next(0, count); //1 ile gelen verilerin sayısı arasında rastgele sayı ürettik.(bunu indis için yaptım.)
                for (int j = 0; j < i; j++) //rastgele üretilen sayı dizinin şuanki indisine kadar kontrol ediyor.(bunu 0 için yaptım. çünkü sıfırda patlıyordu.)
                {
                    if (dizi[j]==a) //aynı sayı üretmemesi için kontrol ediyor.(yada aynı indis vermemesi için questiondetail için.)
                    {                        
                        //j--;
                        durum = false;
                        break;
                        //continue;
                    }
                    else
                    {
                        durum = true;
                    }
                }
                if (durum == true) //eğer üretilen rastgele sayı (veya indis) dizinin içinde yoksa diziye at ve o indisin question id sini dizi2 ye ver.
                {
                    dizi[i] = a;
                    dizi2[i] = questionDetails[a].QuestionId;
                }
                else //eğer random üretilen sayı aynı sayı geldiyse bidaha üretmesi için i azaltıldı.
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
                int a = questiondetail[i];
                questions.Add(_questionDal.Get(x => x.QuestionId == a));
            }
            return questions;
        }
    }
}
