using System;

class ReverseNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReversedNumber(number));
    }
    static string ReversedNumber(string number)
    {
        string newNumber = null;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            newNumber += number[i];
        }
        return newNumber;
    }
}

