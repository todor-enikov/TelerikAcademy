using ASP.NETDataBinding._2.Task_Employee.Data;
using ASP.NETDataBinding.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            //IDataProvider provider = new DataProvider(new EmployeeInfo());
            IDataProvider provider = NinjectWebCommon.Kernel.Get<IDataProvider>();

            this.EmployeesGridView.DataSource = provider.GetAllEmployees();
            this.EmployeesGridView.DataBind();
        }
    }
}