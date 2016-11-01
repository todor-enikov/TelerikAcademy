using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string namePerson)
        {
            this.Name = namePerson;
        }
        public Person(string namePerson, int? agePerson)
            : this(namePerson)
        {
            this.Age = agePerson;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("You have to enter a name!");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                if (value < 0 || value > 150)
                {
                    Console.WriteLine("There is not such person with this kind of age!!!");
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Information for: {0}\n", this.Name);
            if (this.Age == null)
            {
                result.AppendFormat("The age of the person is not declared!");
            }
            else
            {
                result.AppendFormat("Age: {0}", this.Age);
            }
            result.AppendLine();
            return result.ToString();
        }
    }
}
