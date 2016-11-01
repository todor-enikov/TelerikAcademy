namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName, string lab)
            : base(name, teacherName)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            var fromBaseClassToString = base.ToString();
            var resultForLocalCourse = new StringBuilder();
            resultForLocalCourse.Append("LocalCourse { Name = ");
            resultForLocalCourse.Append(this.Name);
            resultForLocalCourse.Append(fromBaseClassToString);
            if (this.Lab != null)
            {
                resultForLocalCourse.Append("; Lab = ");
                resultForLocalCourse.Append(this.Lab);
            }

            resultForLocalCourse.Append(" }");
            return resultForLocalCourse.ToString();
        }
    }
}