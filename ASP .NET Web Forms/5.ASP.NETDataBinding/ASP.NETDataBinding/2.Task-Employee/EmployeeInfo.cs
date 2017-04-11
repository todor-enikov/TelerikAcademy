using ASP.NETDataBinding._2.Task_Employee.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public class EmployeeInfo : NorthwindEntities, IEmployeeInfo
    {
        public IDbSet<Employee> Employees
        {
            get
            {
                return base.Employees;
            }
        }

    }
}