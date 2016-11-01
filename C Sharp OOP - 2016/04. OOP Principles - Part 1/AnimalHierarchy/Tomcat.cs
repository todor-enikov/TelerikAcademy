using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Animal, ISound
    {
        public Tomcat(string name, int age)
            : base(name, "Male", age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Miauu");
        }
    }
}
