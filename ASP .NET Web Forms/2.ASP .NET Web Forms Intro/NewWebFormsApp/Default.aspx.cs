using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewWebFormsApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FromC.Text = "Hello, ASP.NET C# code.";
            this.Location.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}