using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindLongestSubsequence
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var inputList = new List<int> { 1, 1, 1, 1, 2, 3, 4, 4, 5, 6, 6, 6 };
            var result = FindSequnce(inputList);
            Console.WriteLine(string.Join(", ", result));
        }

        public static List<int> FindSequnce(List<int> list)
        {
            var tempList = new List<int>();
            var finalList = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                //tempList.Add(list[i - 1]);
                if (list[i] == list[i - 1])
                {
                    tempList.Add(list[i]);
                }
                else
                {
                    if (tempList.Count > finalList.Count)
                    {
                        finalList = new List<int>(tempList);
                    }

                    tempList = new List<int>();
                    tempList.Add(list[i]);
                }
            }
            return finalList;
        }
    }
}
