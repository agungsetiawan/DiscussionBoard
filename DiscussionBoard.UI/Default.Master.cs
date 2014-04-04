using DiscussionBoard.BL;
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
        private TagService service = new TagService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<DiscussionBoard.Model.Tag> repaterTag_GetData()
        {
            return service.FindAll();
        }
    }
}