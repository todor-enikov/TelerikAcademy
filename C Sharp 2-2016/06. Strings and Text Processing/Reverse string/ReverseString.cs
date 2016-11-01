using System;

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string newText = "";
        foreach (char symbol in text)
        {
            newText = symbol + newText;
        }
        Console.WriteLine(newText);
    }
}

