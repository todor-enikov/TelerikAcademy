using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private List<double> grades;

        public Student(string firstName, string lastName,List<double> grades)
            : base(firstName, lastName)
        {
            this.Grades = grades;
        }
        public List<double> Grades
        {
            get
            {
                return this.grades;
            }
            set
            {
                this.grades = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("The student {0} {1} has grades {2} ",
                this.FirstName, this.LastName, string.Join(" ", this.Grades));
            return result.ToString();
        }
    }
}
