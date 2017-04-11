using ASP.NETDataBinding._2.Task_Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDataBinding._4.Task_EmployeeNameCountryCity
{
    public partial class ShowingAllEmployees : System.Web.UI.Page
    {
        public IDataProvider provider = new DataProvider(new EmployeeInfo());

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = provider.GetAllEmployees();
            this.GridView1.DataBind(); 
        }

        protected void View_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.GridView1.DataSource = provider.GetAllEmployees();
            this.GridView1.DataBind();
        }
    }
}