using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(string name, string gender, int age)
            : base(name, gender, age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Miauu");
        }
    }
}
