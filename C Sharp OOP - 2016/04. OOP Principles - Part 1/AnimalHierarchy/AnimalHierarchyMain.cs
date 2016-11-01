using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class AnimalHierarchyMain
    {
        static void Main()
        {
            List<Animal> aimals = new List<Animal>();

            aimals.Add(new Cat("Tom", "Male", 4));
            aimals.Add(new Frog("Djeri", "Male", 5));
            aimals.Add(new Cat("Mecana", "Female", 2));
            aimals.Add(new Tomcat("Lari", 7));
            aimals.Add(new Cat("Ton", "Male", 9));

            Console.WriteLine("Average age: {0:F2}", Animal.AverageAges(aimals));
        }
    }
}
