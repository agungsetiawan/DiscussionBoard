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
    public partial class Confirm : System.Web.UI.Page
    {
        private UserService service = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["Email"] != null)
            {
                string email = Request.QueryString["Email"].ToString();
                User user = service.FindByEmail(email);

                if (user == null)
                {
                    lblEmail.Text = "Register first before you can activate your account";
                }
                else
                {
                    user.IsActive = true;
                    service.Update(user);
                    lblEmail.Text = "Thank you "+user.Name+" your account is now active";
                    literalLink.Text = "You can now login <a href='" + Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "/Login.aspx'>here</a> ";
                }
            }
            else
            {
                lblEmail.Text = "Register first before you can activate your account";
            }

            
        }
    }
}