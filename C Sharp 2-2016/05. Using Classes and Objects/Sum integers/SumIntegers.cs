using System;
using System.Collections.Generic;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int sum = 0;
        foreach (string number in numbers)
        {
            sum += Convert.ToInt32(number);
        }
        Console.WriteLine(sum);
    }
}

