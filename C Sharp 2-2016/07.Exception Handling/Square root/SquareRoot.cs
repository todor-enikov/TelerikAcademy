using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());       
            var square = Math.Sqrt(number).ToString("F3");
            if (square=="NaN")
            {
                throw new System.FormatException();
            }
            else
            {
                Console.WriteLine(square);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

