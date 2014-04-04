using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.DA
{
    public class QuestionRepository
    {
        private MyContext context = new MyContext();

        public void Save(Question question)
        {
            context.Questions.Add(question);
            context.SaveChanges();
        }

        public void Update(Question question)
        {
            context.Entry(question).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Question FindById(int id)
        {
            Question question = context.Questions.SingleOrDefault(q => q.QuestionId == id);
            return question;
        }

        public List<Question> FindAll()
        {
            List<Question> questions = context.Questions.ToList();
            return questions;
        }
    }
}
