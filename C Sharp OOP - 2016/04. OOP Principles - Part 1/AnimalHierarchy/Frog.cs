using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(string name, string gender, int age)
            : base(name, gender, age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Kvak");
        }
    }
}
