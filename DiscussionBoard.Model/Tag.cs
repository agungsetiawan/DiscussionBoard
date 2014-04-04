using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.Model
{
    public class Tag
    {
        public int TagId { get; set;}
        public string Label { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
