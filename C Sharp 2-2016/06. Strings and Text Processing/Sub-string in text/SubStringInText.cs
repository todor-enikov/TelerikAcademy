using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();
        int currentIndex = text.IndexOf(pattern);
        int counter = 0;
        while (currentIndex >= 0)
        {
            counter++;
            currentIndex = currentIndex + 1;
            currentIndex = text.IndexOf(pattern, currentIndex);
        }
        Console.WriteLine(counter);
    }
}

