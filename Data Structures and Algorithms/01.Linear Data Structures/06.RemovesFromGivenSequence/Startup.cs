using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemovesFromGivenSequence
{
    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            int counter = 0;
            var counters = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                for (int j = 0; j < sequence.Count; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        counter++;
                    }
                }

                counters.Add(counter);
                counter = 0;
            }

            for (int i = 0; i < counters.Count; i++)
            {
                if (counters[i] % 2 != 0)
                {
                    sequence[i] = 0;
                }
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == 0)
                {
                    sequence.Remove(sequence[i]);
                }
            }

            sequence.Remove(0);
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
