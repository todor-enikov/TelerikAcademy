using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    public class Teacher : IPeople, IComment
    {
        private string name;
        private List<Disciplines> disciplines;

        public Teacher(string nameOfTeacher)
        {
            this.Name = nameOfTeacher;
            this.Disciplines = new List<Disciplines>();
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

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public string Comments { get; set; }

        public void AddDiscipline(Disciplines discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Teacher {0} with disciplines: {1}\n", this.Name, string.Join(" ", Disciplines));
            return result.ToString();
        }

    }
}
