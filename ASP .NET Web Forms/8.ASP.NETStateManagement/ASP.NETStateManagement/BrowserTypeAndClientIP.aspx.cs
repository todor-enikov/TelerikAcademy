using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETStateManagement
{
    public partial class BrowserTypeAndClientIP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BrowserType.Text = this.Request.Browser.Type + " " + this.Request.Browser.Version;
            this.IpAddress.Text = GetUserIP();
        }

        private string GetUserIP()
        {
            string ipList = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}