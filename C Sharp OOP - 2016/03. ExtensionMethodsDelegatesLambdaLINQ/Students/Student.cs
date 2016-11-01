using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student //task9
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private int age;

        public Student(string firstNameStudent, string lastNameStudent,
                      string facultyNumberStudent, string telNumberStudent,
                      string emailStudent, int groupNumberStudent, int ageStudent)
        {
            this.FirstName = firstNameStudent;
            this.LastName = lastNameStudent;
            this.FacultyNumber = facultyNumberStudent;
            this.TelNumber = telNumberStudent;
            this.Email = emailStudent;
            this.GroupNumber = groupNumberStudent;
            this.Age = ageStudent;
            this.Marks = new List<int>();

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 0 || value.Length > 10)
                {
                    throw new ArgumentException("The firstname of the student should be between 0 and 10 symbols");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 0 || value.Length > 10)
                {
                    throw new ArgumentException("The lastname of the student should be between 0 and 10 symbols");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length < 0 || value.Length > 10)
                {
                    throw new ArgumentException("The faculty number of the student should be between 0 and 10 symbols");
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }

        public string TelNumber
        {
            get
            {
                return this.telNumber;
            }
            set
            {
                if (value.Length < 0 || value.Length > 10)
                {
                    throw new ArgumentException("The telephone number of the student should be between 0 and 10 symbols");
                }
                else
                {
                    this.telNumber = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 1 || value > 300)
                {
                    throw new ArgumentException("The group number of the student should be between 1 and 3 symbols");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 18 || value > 30)
                {
                    throw new ArgumentException("The age of the student should be between 18 and 30 years.");
                }
                this.age = value;
            }
        }

        public void AddMarks(int[] marks)
        {
            this.marks.AddRange(marks);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("------------------------------------------\n");
            result.AppendFormat("The first name of the student is: {0}\n", this.FirstName);
            result.AppendFormat("The last name of the student is: {0}\n", this.LastName);
            result.AppendFormat("The age of the student is: {0}\n", this.Age);
            result.AppendFormat("The mail of the student is: {0}\n", this.Email);

            return result.ToString();
        }
    }
}
