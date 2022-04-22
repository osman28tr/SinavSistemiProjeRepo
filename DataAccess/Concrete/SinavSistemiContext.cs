using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class SinavSistemiContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<QuestionDetail> QuestionDetails { get; set; }
        public DbSet<WrongAnswer> WrongAnswers { get; set; }
        //public DbSet<SigmaTime> SigmaTimes { get; set; }
        public DbSet<Sigma> Sigmas { get; set; }
    }
}
