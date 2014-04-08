using DiscussionBoard.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussionBoard.UI
{
    public partial class Default1 : System.Web.UI.Page
    {
        private IQuestionService service = new QuestionService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                string name = Session["Name"].ToString();
                string email = Session["Email"].ToString();

                literalHello.Text="Hello,  <b>"+name+"</b> <br />Your Email is "+email;
            }
        }

        public IEnumerable<DiscussionBoard.Model.Question> repeaterQuestion_GetData()
        {
            return service.FindPopular();
        }

        public IEnumerable<DiscussionBoard.Model.Question> repeaterLatestQuestion_GetData()
        {
            return service.FindNewest();
        }
    }
}