using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public interface IUserService
    {
        bool Login(string email, string password);

        void Register(User user, string rootUrl);

         bool IsEmailExist(string email);

         void Update(User user);

        User FindByEmail(string email);
    }
}
