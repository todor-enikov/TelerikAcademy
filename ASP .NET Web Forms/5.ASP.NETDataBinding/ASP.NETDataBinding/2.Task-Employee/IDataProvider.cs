using ASP.NETDataBinding._2.Task_Employee.Data;
using System.Collections.Generic;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public interface IDataProvider
    {
        IEnumerable<Employee> GetAllEmployees();
        IEnumerable<Employee> GetEmployeeById(int id);
    }
}
