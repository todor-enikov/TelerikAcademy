using ASP.NETDataBinding._2.Task_Employee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public class DataProvider : IDataProvider
    {
        private readonly IEmployeeInfo dbContext;

        public DataProvider(IEmployeeInfo dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.dbContext.Employees.ToList();
        }

        public IEnumerable<Employee> GetEmployeeById(int id)
        {
            return this.dbContext.Employees.Where(em => em.EmployeeID == id).ToList();
        }
    }
}