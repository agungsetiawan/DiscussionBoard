using DiscussionBoard.DA;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public class AnswerService
    {
        private AnswerRepository repository = new AnswerRepository();

        public void Add(Answer answer)
        {
            repository.Save(answer);
        }

        public void Update(Answer answer)
        {
            repository.Update(answer);
        }

        public List<Answer> FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Answer> FindAll()
        {
            return repository.FindAll();
        }

    }
}
