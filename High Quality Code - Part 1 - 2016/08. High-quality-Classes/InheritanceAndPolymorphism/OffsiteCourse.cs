namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name)
            : base(name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public OffsiteCourse(string name, string teacherName)
            : base(name, teacherName)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            var fromBaseClassToString = base.ToString();
            var resultForOffsiteCourse = new StringBuilder();
            resultForOffsiteCourse.Append("OffsiteCourse { Name = ");
            resultForOffsiteCourse.Append(this.Name);
            resultForOffsiteCourse.Append(fromBaseClassToString);
            if (this.Town != null)
            {
                resultForOffsiteCourse.Append("; Town = ");
                resultForOffsiteCourse.Append(this.Town);
            }

            resultForOffsiteCourse.Append(" }");
            return resultForOffsiteCourse.ToString();
        }
    }
}