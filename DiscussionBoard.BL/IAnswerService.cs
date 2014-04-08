using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public interface IAnswerService
    {
        void Add(Answer answer);

        void Update(Answer answer);

        List<Answer> FindById(int id);

        Answer FindySingleAnswerById(int id);

        List<Answer> FindAll();
    }
}
