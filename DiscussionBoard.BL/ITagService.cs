using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public interface ITagService
    {
         void Save(Tag tag);

        void Remove(Tag tag);

        List<string> FindAll();
    }
}
