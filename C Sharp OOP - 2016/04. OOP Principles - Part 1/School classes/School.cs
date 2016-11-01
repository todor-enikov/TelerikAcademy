using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    public class School : IComment
    {
        private string name;
        private List<ClassInSchool> schoolClass;

        public School(string nameOfSchool)
        {
            this.Name = nameOfSchool;
            this.SchoolClass = new List<ClassInSchool>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("The length of the name cannot be less than two symbols!");
                }
                this.name = value;
            }
        }

        public List<ClassInSchool> SchoolClass
        {
            get
            {
                return this.schoolClass;
            }
            set
            {
                this.schoolClass = value;
            }
        }

        public string Comments { get; set; }

        public void AddClass(ClassInSchool schoolClass)
        {
            this.SchoolClass.Add(schoolClass);
        }

        public void RemoveClass(ClassInSchool schoolClass)
        {
            this.SchoolClass.Remove(schoolClass);
        }
    }
}
