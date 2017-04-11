using ASP.NETDataBinding._2.Task_Employee;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDataBinding.App_Start
{
    public class EmployeeNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDataProvider>().To<DataProvider>();
            this.Bind<IEmployeeInfo>().To<EmployeeInfo>();
        }
    }
}