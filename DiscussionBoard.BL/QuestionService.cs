using DiscussionBoard.DA;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public class QuestionService
    {
        private QuestionRepository repository = new QuestionRepository();

        public void Add(Question question)
        {
            repository.Save(question);
        }

        public void Update(Question question)
        {
            repository.Update(question);
        }

        public Question FindById(int id)
        {
            return repository.FindById(id);
        }

        public IEnumerable<Question> FindByTag(string tag)
        {
            IEnumerable<Question> questions = repository.FindAll().Where(q => q.Status == 1);
            questions = questions.Where(q => q.Tags.Where(t => t.Label == tag).Any()).ToList();
            return questions;
        }

        public IEnumerable<Question> FindPopular()
        {
            IEnumerable<Question> popularQuestion = repository.FindAll().Where(q => q.Status == 1);
            popularQuestion = popularQuestion.Where(pq => pq.Answers.Where(a => a.Date > DateTime.Now.AddDays(-7)).Any() )
                .OrderByDescending(pq => pq.Answers.Where(a => a.Date > DateTime.Now.AddDays(-7)).Count()).Take(10).ToList();
            return popularQuestion;
        }

        public IEnumerable<Question> FindNewest()
        {
            IEnumerable<Question> questions = repository.FindAll().Where(q => q.Status == 1);
            questions = questions.OrderByDescending(q => q.CreatedDate).ToList();
            return questions;
        }

        public IEnumerable<Question> FindByUserEmail(string userEmail)
        {
            IEnumerable<Question> questions = repository.FindAll().Where(q => q.User.Email == userEmail);
            return questions;
        }
    }
}
