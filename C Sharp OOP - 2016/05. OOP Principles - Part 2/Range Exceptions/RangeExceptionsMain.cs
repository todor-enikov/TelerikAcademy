using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Exceptions
{
    class RangeExceptionsMain
    {
        static void Main()
        {
            Console.WriteLine("Uncomment the code and you can try the first exception.\n");
            //try
            //{
            //    int number = -100;
            //    if (number < 1 || number > 100)
            //    {
            //        throw new InvalidRangeException<int>("Invalid number!", 1, 100);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your number is in range.");
            //    }
            //}
            //catch (InvalidRangeException<int> ex)
            //{
            //    Console.WriteLine("The number should be between {0} and {1}", ex.Start, ex.End);
            //    throw;
            //}

            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            try
            {
                DateTime dateNow = DateTime.Now;
                Console.WriteLine(dateNow);
                if (dateNow < start || dateNow > end)
                {
                    throw new InvalidRangeException<DateTime>("Invalid date!", start, end);
                }
                else
                {
                    Console.WriteLine("Your date is in range.");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("The date should be between {0} and {1}", start, end);
                throw;
            }
        }
    }
}
