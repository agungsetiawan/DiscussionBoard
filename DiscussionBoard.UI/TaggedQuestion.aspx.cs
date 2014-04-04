using DiscussionBoard.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussionBoard.UI
{
    public partial class TaggedQuestion : System.Web.UI.Page
    {
        private QuestionService service = new QuestionService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<DiscussionBoard.Model.Question> repeaterQuestion_GetData()
        {
            if (Request.QueryString["ID"] != null)
            {
                string id = Request.QueryString["ID"].ToString();
                
                var questions=service.FindByTag(id);
                return questions;
            }
            else
            {
                Response.Redirect("Default.aspx");
                return null;
            }
        }

        
    }
}