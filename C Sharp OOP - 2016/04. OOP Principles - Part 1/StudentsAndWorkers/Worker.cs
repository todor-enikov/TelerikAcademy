using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("The worker {0} {1} has earned {2} $ per hour", this.FirstName, this.LastName, this.MoneyPerHour());
            return result.ToString();
        }
    }
}
