using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceOfIntegers
{
    public class Startup
    {
        public static void Main()
        {
            var sequenceList = new List<int>();
            while (true)
            {
                string value = Console.ReadLine();
                if (value == string.Empty)
                {
                    break;
                }
                sequenceList.Add(int.Parse(value));
            }

            sequenceList.Sort();
            Console.WriteLine(string.Join(", ",sequenceList));
        }
    }
}
