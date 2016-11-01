using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBySevenAndThree
{
    public static class ExtinsionMethods
    {
        public static IEnumerable<T> DivisibleLambda<T>(this IEnumerable<T> numbers)
        {
            var result = numbers.Where(num => (dynamic)num % 7 == 0 && (dynamic)num % 3 == 0);
            return result;
        }

        public static IEnumerable<T> DivisibleLINQ<T>(this IEnumerable<T> numbers)
        {
            var result = from number in numbers
                         where (dynamic)number % 7 == 0 && (dynamic)number % 3 == 0
                         select number;
            return result;
        }
    }
}
