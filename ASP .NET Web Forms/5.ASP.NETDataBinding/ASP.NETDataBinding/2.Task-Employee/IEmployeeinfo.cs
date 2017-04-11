using ASP.NETDataBinding._2.Task_Employee.Data;
using System.Data.Entity;

namespace ASP.NETDataBinding._2.Task_Employee
{
    public interface IEmployeeInfo
    {
        IDbSet<Employee> Employees { get; }
    }
}
