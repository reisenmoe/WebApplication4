using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nav_Click(object sender, EventArgs e)
        {
            Response.Redirect("OtherPage.aspx");
        }

        protected void Nav2_Click(object sender, EventArgs e)
        {
            Response.Redirect("OtherPageManual.aspx");
        }
    }
}