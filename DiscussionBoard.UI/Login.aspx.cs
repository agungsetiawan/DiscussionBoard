using DiscussionBoard.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionBoard.Model;

namespace DiscussionBoard.UI
{
    public partial class Login : System.Web.UI.Page
    {
        private IUserService service = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = service.Login(txtEmail.Text, txtPassword.Text);

            if (result == true)
            {
                User user=service.FindByEmail(txtEmail.Text);
                Session["Name"] = user.Name;
                Session["Email"] = user.Email;

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblLogin.Text = "Invalid Email Address and or Password!";
            }
        }
    }
}