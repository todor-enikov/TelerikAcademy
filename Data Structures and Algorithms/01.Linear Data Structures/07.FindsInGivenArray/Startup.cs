using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindsInGivenArray
{
    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var result = new SortedDictionary<int, int>();
            foreach (var item in sequence)
            {
                bool isAdded = result.ContainsKey(item);
                if (isAdded)
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }
            
            foreach (var item in result)
            {           
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }
        }
    }
}
