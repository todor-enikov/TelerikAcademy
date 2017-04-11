using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviders
{
    public class Startup
    {
        private static void Swap(ref long a, ref long b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(long[] list, List<long> resoult)
        {
            long x = list.Length - 1;
            GetPer(list, 0, x, resoult);
        }

        private static void GetPer(long[] list, long k, long m, List<long> result)
        {
            if (k == m)
            {
                result.Add(long.Parse(string.Join("", list)));
            }
            else
                for (long i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m, result);
                    Swap(ref list[k], ref list[i]);
                }
        }

        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            long[] arr = new long[n];
            for (long i = 0; i < n; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }

            List<long> resoutl = new List<long>();
            GetPer(arr, resoutl);
            long minDel = long.MaxValue;
            long number = 0;

            foreach (var item in resoutl)
            {
                var currentCOunt = 0;
                for (long i = 1; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        currentCOunt++;
                    }
                    else
                    {
                        continue;
                    }
                }


                if (currentCOunt < minDel)
                {
                    minDel = currentCOunt;
                    number = item;
                }

            }

            Console.WriteLine(number);
        }
    }
}
