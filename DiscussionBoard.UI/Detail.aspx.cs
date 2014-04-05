using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionBoard.BL;
using DiscussionBoard.Model;

namespace DiscussionBoard.UI
{
    public partial class Detail : System.Web.UI.Page
    {
        AnswerService answerService = new AnswerService();
        UserService userService = new UserService();
        QuestionService questionService = new QuestionService();
        TagService tagService = new TagService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                answerButton.Visible = false;
                loginAnswer.Visible = true;
            }
            if (Request.QueryString["ID"] != null)
            {
                Question question = questionService.FindById(Convert.ToInt32(Request.QueryString["ID"].ToString()));
                contentQuestion.InnerHtml = question.Content;
                titleQuestion.InnerHtml = question.Title;
                byQuestion.InnerHtml = question.User.Name;
                dateQuestion.InnerHtml = question.CreatedDate.ToString();

                //Tag tag = question.Tags;
            }
            else
            {
                invalidNotif.InnerHtml = "Invalid URL";
            }


            if (!IsPostBack)
            {
                foreach (RepeaterItem ritem in repeaterAnswer.Items)
                {
                    Button btn = ritem.FindControl("btnUpVote") as Button;
                    btn.Click += new EventHandler(upvote_Click);

                    Button btn1 = ritem.FindControl("btnDownVote") as Button;
                    btn1.Click += new EventHandler(downvote_Click);
                }
            }
        }

        public IEnumerable<DiscussionBoard.Model.Answer> repeaterAnswer_GetData()
        {
            if (Request.QueryString["ID"] != null)
            {
                return answerService.FindById(Convert.ToInt32(Request.QueryString["ID"].ToString()));
            }
            else
            {
                return null;
            }
            
            
        }

        public IEnumerable<DiscussionBoard.Model.Tag> repeaterTag_GetData()
        {
            
            if (Request.QueryString["ID"] != null)
            {
                Question question = questionService.FindById(Convert.ToInt32(Request.QueryString["ID"].ToString()));
                return question.Tags;
            }
            else
            {
                return null;
            }


        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            User user = userService.FindByEmail(Session["Email"].ToString());
            string _content = ContentAnswer.Text;
            int _id = user.UserId;
            //int _questionId = QuestionId.Value;          
            int _questionId = Convert.ToInt32(Request.QueryString["ID"].ToString());

            Answer data = new Answer 
            { 
                Content = _content,
                Vote = 0,
                Spam = 0,
                Date = DateTime.Now,
                UserId = _id,
                QuestionId = _questionId
            };


            AnswerService service = new AnswerService();
            service.Add(data);

            successNotif.Visible = true;
            Response.Redirect(Request.RawUrl);
            

        }

        protected void upvote_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var id = btn.CommandArgument.ToString();

            Answer data = answerService.FindySingleAnswerById(int.Parse(id));
            data.Vote += 1;
            answerService.Update(data);

            Response.Redirect(Request.RawUrl);

        }

        protected void downvote_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var id = btn.CommandArgument.ToString();

            Answer data = answerService.FindySingleAnswerById(int.Parse(id));
            data.Vote -= 1;
            answerService.Update(data);

            Response.Redirect(Request.RawUrl);

        }

    }
}