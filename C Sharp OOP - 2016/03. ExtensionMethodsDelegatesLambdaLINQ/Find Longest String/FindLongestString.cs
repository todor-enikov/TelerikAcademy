using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Longest_String
{
    class FindLongestString //task17
    {
        static void Main()
        {
            var words = new string[] { "Psiho", "Ivan", "Petyr", "Georgi", "Cvetan", "Sokolov" };

            Console.WriteLine("Finding the longest string in an array.");
            foreach (var word in words)
            {
                Console.Write(word +" ");
            }
            Console.WriteLine();
            Console.WriteLine("The longest string is: {0}",words.FindingString());
        }
    }
}
