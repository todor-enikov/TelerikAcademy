using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IDataProvider provider = new DataProvider(new EmployeeInfo());

            var id =int.Parse(this.Request.QueryString["id"]);
            this.DetailsView1.DataSource = provider.GetEmployeeById(id);
            this.DetailsView1.DataBind();

        }
    }
}