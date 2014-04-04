using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.DA
{
    public class TagRepository
    {
        private MyContext context = new MyContext();

        public void Save(Tag tag)
        {
            context.Tags.Add(tag);
            context.SaveChanges();
        }

        public void Remove(Tag tag)
        {
            context.Tags.Remove(tag);
            context.SaveChanges();
        }

        public List<Tag> FindAll()
        {
            return context.Tags.ToList();
        }
    }
}
