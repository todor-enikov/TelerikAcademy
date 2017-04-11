using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControls
{
    public partial class ValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                this.Result.Text = "Validation passed!";
            }
            else
            {
                this.Result.Text = "Validation did not pass!";
            }

            if (this.GenderList.Text == "Male")
            {
                this.CheckBoxListCars.Visible = true;
                this.CheckBoxListCoffees.Visible = false;
            }
            else if (this.GenderList.Text == "Female")
            {
                this.CheckBoxListCars.Visible = false;
                this.CheckBoxListCoffees.Visible = true;
            }
        }
    }
}