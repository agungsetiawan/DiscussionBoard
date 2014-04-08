using DiscussionBoard.BL;
using DiscussionBoard.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussionBoard.UI
{
    public partial class PostAQuestion : System.Web.UI.Page
    {
        private IQuestionService qService = new QuestionService();
        private IUserService uService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            var emailUser = Session["Email"].ToString();
            var title = txtTitle.Text;
            var content = txtQuestion.Text;
            var tags = txtTag.Text;
            var status = ddlStatus.SelectedValue;
            var listTag = ConvertStrToTags(tags);

            // get User from email
            var user = uService.FindByEmail(emailUser);

            var question = new Question()
            {
                Title = title,
                Content = content,
                CreatedDate = DateTime.Now,
                Status = status == "Publish" ? 1 : 0,
                UserId = user.UserId,
                Tags = listTag
            };

            qService.Add(question);

            ClearForm();

            lblMessage.Text = "Thank You. Your Question has been sent.";
        }

        private void ClearForm()
        {
            txtTitle.Text = String.Empty;
            txtTag.Text = String.Empty;
            txtQuestion.Text = String.Empty;
        }

        private List<Tag> ConvertStrToTags(string tags)
        {
            List<Tag> result = new List<Tag>();
            var list = tags.Split(',');
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach (var tag in list)
            {
                result.Add(new Tag {
                     Label = ti.ToTitleCase(tag.Trim())
                });
            }
            return result;
        }
    }
}