using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        private int age;
        private string name;
        private string gender;

        public Animal(string name, string sex, int age)
        {
            this.Name = name;
            this.Gender = sex;
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public static double AverageAges(List<Animal> list)
        {
            var resoult = list.Sum(x => x.Age) / (double)list.Count;

            return resoult;
        }
    }
}
