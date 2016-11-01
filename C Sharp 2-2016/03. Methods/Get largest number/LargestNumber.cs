using System;
using System.Linq;
class LargestNumber
{
    static void Main()
    {
        GetMax();
    }
    static void GetMax()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
        {
            Console.WriteLine(numbers[0]);
        }
        else if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
        {
            Console.WriteLine(numbers[1]);
        }
        else
        {
            Console.WriteLine(numbers[2]);
        }
    }
}

