﻿using DiscussionBoard.DA;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Tag> FindAll()
        {
            return repository.FindAll();
        }
    }
}