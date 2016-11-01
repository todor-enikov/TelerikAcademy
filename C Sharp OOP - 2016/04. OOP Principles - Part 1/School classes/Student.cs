using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    public class Student : IPeople, IComment
    {
        private string name;
        private int uniqueNumber;

        public Student(string nameOfStudent, int uniqueNumberOfStudent)
        {
            this.Name = nameOfStudent;
            this.UniqeNumber = uniqueNumberOfStudent;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int UniqeNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The uniquenumber cannot be less than 0 and equal to 0!");
                }
                this.uniqueNumber = value;
            }
        }

        public string Comments { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("The student has name {0} and unique number {1}\n", this.Name, this.UniqeNumber);
            return result.ToString();
        }
    }
}
