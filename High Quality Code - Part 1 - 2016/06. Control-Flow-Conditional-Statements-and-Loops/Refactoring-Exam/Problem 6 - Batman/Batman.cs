using System;

public class Batman
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char batmanChar = char.Parse(Console.ReadLine());
        int spaces = 0;
        int symbols = size;
        int insideSpaces = size;
        int spacesBetweenEars = (size / 2) - 1;

        for (int i = 0; i < (size / 2) - 1; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.Write(new string(batmanChar, symbols));
            Console.Write(new string(' ', insideSpaces));
            Console.WriteLine(new string(batmanChar, symbols));
            spaces++;
            symbols--;
        }

        Console.Write(new string(' ', spaces));
        Console.Write(new string(batmanChar, symbols));
        Console.Write(new string(' ', spacesBetweenEars));
        Console.Write(batmanChar);
        Console.Write(' ');
        Console.Write(batmanChar);
        Console.Write(new string(' ', spacesBetweenEars));
        Console.WriteLine(new string(batmanChar, symbols));
        spaces++;

        for (int i = 0; i < (size / 2) - 1; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.WriteLine(new string(batmanChar, (size * 2) + 1));
        }

        int newSpaces = size + 1;
        int newSymbols = size - 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write(new string(' ', newSpaces));
            Console.WriteLine(new string(batmanChar, newSymbols));
            newSpaces++;
            newSymbols -= 2;
        }
    }
}