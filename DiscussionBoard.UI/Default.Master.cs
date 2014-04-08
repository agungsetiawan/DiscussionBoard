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
    public partial class Default : System.Web.UI.MasterPage
    {
        private ITagService service = new TagService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<String> repaterTag_GetData()
        {
            return service.FindAll();
        }
    }
}