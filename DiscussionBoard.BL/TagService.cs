using DiscussionBoard.DA;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DiscussionBoard.BL
{
    public class TagService
    {
        private TagRepository repository = new TagRepository();

        public void Save(Tag tag)
        {
            repository.Save(tag);
        }

        public void Remove(Tag tag)
        {
            repository.Remove(tag);
        }

        public List<string> FindAll()
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return repository.FindAll().Select(p => ti.ToTitleCase(p.Label)).Distinct().ToList();
        }
    }
}
