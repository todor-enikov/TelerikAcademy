using System;

class CorrectBrackets
{
    static void Main()
    {
        string text = Console.ReadLine();
        int openBrackets = 0;
        int closedBrackets = 0;

        foreach (char symbol in text)
        {
            if (symbol == '(')
            {
                openBrackets++;
            }
            if (symbol == ')')
            {
                closedBrackets++;
            }
        }

        if (openBrackets == closedBrackets)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

