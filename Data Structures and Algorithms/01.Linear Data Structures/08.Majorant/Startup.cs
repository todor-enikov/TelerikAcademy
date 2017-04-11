using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Majorant
{
    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var majorant = (sequence.Count / 2) + 1;
            var occurances = new Dictionary<int, int>();
            foreach (var item in sequence)
            {
                bool isAdded = occurances.ContainsKey(item);
                if (isAdded)
                {
                    occurances[item]++;
                }
                else
                {
                    occurances.Add(item, 1);
                }
            }

            foreach (var item in occurances)
            {
                if (majorant <= item.Value)
                {
                    Console.WriteLine("{0} Has majorant.",item.Key);
                }
                else
                {
                    Console.WriteLine("{0} Does not have majorant.", item.Key);
                }
            }

        }
    }
}

