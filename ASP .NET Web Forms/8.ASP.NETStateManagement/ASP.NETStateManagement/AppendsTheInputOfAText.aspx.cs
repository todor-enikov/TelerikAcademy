using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETStateManagement
{
    public partial class AppendsTheInputOfAText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonForTheTextBox_Click(object sender, EventArgs e)
        {
            var textFromtextBox = this.InputTextBox.Text;
            Session["AllStrings"] = textFromtextBox;
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (Session["AllStrings"] == null)
            {
                Session["AllStrings"] = "";
            }

            this.Result.Text += Session["AllStrings"].ToString() + " ";
        }
    }
}