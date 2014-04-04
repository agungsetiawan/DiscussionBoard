using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.DA
{
    public class AnswerRepository
    {
        private MyContext context = new MyContext();

        public void Save(Answer answer)
        {
            context.Answers.Add(answer);
            context.SaveChanges();
        }

        public void Update(Answer answer)
        {
            //Answer answerToEdit = context.Answers.SingleOrDefault(a=>a.AnswerId==answer.AnswerId);
            context.Entry(answer).State = EntityState.Modified;
            context.SaveChanges();
        }



        public List<Answer> FindById(int id)
        {
            return context.Answers.Where(a => a.QuestionId == id).ToList();
            //return answer;
        }

        public List<Answer> FindAll()
        {
            return context.Answers.ToList();
        }
    }
}
