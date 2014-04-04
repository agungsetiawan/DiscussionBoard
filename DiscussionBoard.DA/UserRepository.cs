using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.DA
{
    public class UserRepository
    {
        private MyContext context = new MyContext();

        public void Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }

        public User FindByEmailAndPassword(string email, string password)
        {
            User user=context.Users.FirstOrDefault(u=>u.Email==email && u.Password==password && u.IsActive==true);
            return user;
        }

        public User FindyByEmail(string email)
        {
            User user = context.Users.SingleOrDefault(u => u.Email == email);
            return user;
        }
    }
}
