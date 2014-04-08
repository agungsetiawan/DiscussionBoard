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
    public partial class Dashboard : System.Web.UI.Page
    {
        private IQuestionService service = new QuestionService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IEnumerable<DiscussionBoard.Model.Question> repeaterQuestion_GetData()
        {
            if (Session["Email"] != null)
            {
                string email = Session["Email"].ToString();
                return service.FindByUserEmail(email);
            }
            else {
                Response.Redirect("Login.aspx");
            }

            return new List<Question>();
        }
    }
}