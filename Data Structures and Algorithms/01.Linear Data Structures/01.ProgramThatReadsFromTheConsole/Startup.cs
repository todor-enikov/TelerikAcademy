using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProgramThatReadsFromTheConsole
{
    public class Startup
    {
        public static void Main()
        {
            var sequenceList = new List<int>();
            while (true)
            {
                Console.Write("Enter number: ");
                var value = Console.ReadLine();
                if (value == string.Empty)
                {
                    break;
                }

                sequenceList.Add(int.Parse(value));
            }

            var sum = 0;
            foreach (var element in sequenceList)
            {
                sum += element;
            }
            var average = sum / sequenceList.Count;

            Console.WriteLine("The sum of the elements is: {0}", sum);
            Console.WriteLine("The average of the elements in the sequence is: {0}", average);
        }
    }
}
