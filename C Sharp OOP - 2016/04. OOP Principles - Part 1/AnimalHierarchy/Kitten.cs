using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten : Animal, ISound
    {
        public Kitten(string name, int age)
            : base(name, "Female", age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Miauu");
        }
    }
}
