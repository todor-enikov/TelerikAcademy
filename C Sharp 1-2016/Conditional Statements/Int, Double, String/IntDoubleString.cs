//Write a program that, depending on the first line of the input, reads an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {

        string variable = Console.ReadLine();
        switch (variable)
        {
            case "integer": int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", integer + 1);
                break;
            case "real": double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", doubleNumber + 1);
                break;
            case "text": string text = Console.ReadLine();
                Console.WriteLine("{0}*", text);
                break;
            default: Console.WriteLine("Invalid input!");
                break;

        }
    }
}

