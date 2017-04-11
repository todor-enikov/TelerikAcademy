using ASP.NETAJAX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETAJAX
{
    public partial class AjaxEnabledShowsEmployeesandOrders : System.Web.UI.Page
    {
        //I could not finished the task so i do it like that
        //when you start this page change the url with this one: 
        //http://localhost:59997/AjaxEnabledShowsEmployeesandOrders?id=1
        //and the page will start working properly.
        private NorthwindEntities northwind = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            var employees = northwind.Employees.ToList();        
            this.Employees.DataSource = employees;
            this.Employees.DataBind();
            this.UpdatePanelOrders.Visible = false;
        }

        protected void Employees_PreRender(object sender, EventArgs e)
        {
            var id = int.Parse(this.Request.QueryString["id"]);
            var orders = northwind.Orders.Where(o => o.EmployeeID == id).ToList();
            this.Orders.DataSource = orders;
            this.Orders.DataBind();
            this.UpdatePanelOrders.Visible = true;
        }
    }
}