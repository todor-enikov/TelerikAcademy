using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    public class ClassInSchool : IComment
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public ClassInSchool(string classIdentifier)
        {
            this.Identifier = classIdentifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of the identifier cannot be less than 0!");
                }
                this.identifier = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        public string Comments { get; set; }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Students in this class are\n {0} \n Teachers in this class are:\n {1}\n",
                string.Join(" ", Students), string.Join(" ", Teachers));
            return result.ToString();
        }
    }
}
