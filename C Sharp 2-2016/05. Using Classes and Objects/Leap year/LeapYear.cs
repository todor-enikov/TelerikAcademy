using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        LeapOrCommonYear(year);
    }

    static void LeapOrCommonYear(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

