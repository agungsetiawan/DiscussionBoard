using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public interface IQuestionService
    {
        void Add(Question question);

         void Update(Question question);

        Question FindById(int id);

         IEnumerable<Question> FindByTag(string tag);

         IEnumerable<Question> FindPopular();

       IEnumerable<Question> FindNewest();

        IEnumerable<Question> FindByUserEmail(string userEmail);
    }
}
