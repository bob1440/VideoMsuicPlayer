using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    public partial class PlayOneMedia : System.Web.UI.Page
    {
        public string PlayFile = "/Mp4Handler.ashx?txt=japan.mp4";

        protected void Page_Load(object sender, EventArgs e)
        {
           PlayFile ="/Mp4Handler.ashx?txt="+ Request["mn"];

        }
    }
}