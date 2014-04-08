using DiscussionBoard.DA;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionBoard.BL
{
    public class UserService : IUserService
    {
        private UserRepository repository = new UserRepository();

        public bool Login(string email, string password)
        {
            User user = repository.FindByEmailAndPassword(email, password);

            if (user != null)
                return true;
            else
                return false;
        }

        public void Register(User user,string rootUrl)
        {
            repository.Save(user);

            
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(user.Email);
                mailMessage.From = new MailAddress("Agung.Setiawan@mitrais.com");
                mailMessage.Subject = "Registration Confirmation";
                mailMessage.Body = rootUrl + "Confirm.aspx?Email=" + user.Email;
                SmtpClient smtpClient = new SmtpClient("mail.mitrais.com");
                smtpClient.Send(mailMessage);
                smtpClient.EnableSsl = true;

         
        }

        public bool IsEmailExist(string email)
        {
            User userFound = repository.FindyByEmail(email);

            if (userFound == null)
                return false;
            else
                return true;
        }

        public void Update(User user)
        {
            repository.Update(user);
        }

        public User FindByEmail(string email)
        {
            return repository.FindyByEmail(email);
        }
    }
}
