﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETStateManagement.TwoPages
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Log_Click(object sender, EventArgs e)
        {
            var username = this.Username.Text;
            HttpCookie cookie = new HttpCookie("Username", username);
            cookie.Expires.AddMinutes(1);

            this.Response.Cookies.Add(cookie);
            this.Response.Redirect("~/TwoPages/SecondPage.aspx");
        }
    }
}