using DiscussionBoard.BL;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussionBoard.UI
{
    public partial class Register : System.Web.UI.Page
    {
        private IUserService service = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool result = service.IsEmailExist(txtEmail.Text);
            if (result)
            {
                lblEmailExist.Text = "Email is already exist";
            }
            else
            {
                var user = new User()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    IsActive = false,
                    Role = "user"
                };

                service.Register(user, Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath);
                literalSuccess.Text = "Registration success, activate your acount <a href='" + Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "Confirm.aspx?Email="+user.Email+"'>here</a>";
            }
        }
    }
}