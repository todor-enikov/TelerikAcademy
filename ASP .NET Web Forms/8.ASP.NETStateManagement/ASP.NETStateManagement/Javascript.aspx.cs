using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETStateManagement
{
    public partial class Javascript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewState_Click(object sender, EventArgs e)
        {
            ClearChildViewState();
            
            this.View.Text = ViewState.Text;
        }

    }
}