using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Fill_Click(object sender, EventArgs e)
        {
            this.Literal.Text = this.EnterText.Text;
        }
    }
}