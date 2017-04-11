using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegativeNumberFromSequence
{
    public class Startup
    {
        public static void Main()
        {
            var sequenceList = new List<int> { 1, 4, -9, 6, 2, -15, 8, 3, -1, -8, -8, 8, -4 };

            for (int i = 0; i < sequenceList.Count; i++)
            {
                if (sequenceList[i] < 0)
                {
                    sequenceList.Remove(sequenceList[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", sequenceList));
        }
    }
}
