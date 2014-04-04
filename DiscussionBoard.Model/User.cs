using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
