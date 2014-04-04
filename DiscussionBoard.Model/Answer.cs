using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.Model
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int Vote { get; set; }
        public int Spam { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
