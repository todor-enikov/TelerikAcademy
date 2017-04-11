using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETStateManagement.TwoPages
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = this.Request.Cookies["Username"];

            if (cookie == null)
            {
                this.Response.Redirect("~/TwoPages/FirstPage.aspx");
            }
        }
    }
}