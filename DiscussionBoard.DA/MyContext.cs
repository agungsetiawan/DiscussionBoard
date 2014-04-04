using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscussionBoard.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DiscussionBoard.DA
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Question>()
            //    .HasRequired(u => u.User)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();   

        }

        public DbSet<Question> Questions { get; set; }
    }
}
