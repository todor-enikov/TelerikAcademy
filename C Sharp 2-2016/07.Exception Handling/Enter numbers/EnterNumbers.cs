﻿using System;
using System.Collections.Generic;
using System.Linq;

class EnterNumbers
{
    static void Main()
    {

        try
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            string result = "1 ";
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    result += "< " + numbers[i] + " ";
                }

            }
            result += "< 100";
            Console.WriteLine(result);
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//namespace _02.EnterNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = new List<int>();
//            for (int i = 0; i < 10; i++)
//            {
//                numbers.Add(int.Parse(Console.ReadLine()));
//            }
//            PrintIfSorted(0,100,numbers);
//        }
//
//        private static void PrintIfSorted(int start, int end, IList<int> numbers)
//        {
//            try
//            {
//                if (!IsSorted(numbers) || numbers.Any(x => x < start) || numbers.Any(x => x > end))
//                {
//                    throw new ArgumentException();
//                }
//
//                Console.WriteLine("1 < " + string.Join(" < ",numbers) + " < 100");
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Exception");
//            }
//        }
//
//        private static bool IsSorted<T>(IList<T> numbers)
//            where T : IComparable
//        {
//            for (int i = 1; i < numbers.Count; i++)
//            {
//                if (numbers[i - 1].CompareTo(numbers[i]) != -1)
//                {
//                    return false;
//                }
//            }
//
//            return true;
//        }
//    }
//}