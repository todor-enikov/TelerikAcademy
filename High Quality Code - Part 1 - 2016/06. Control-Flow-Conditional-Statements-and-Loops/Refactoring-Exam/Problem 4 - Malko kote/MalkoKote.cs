using System;
using System.Text;

public class MalkoKote
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char catsChar = char.Parse(Console.ReadLine());
        int spaces = 1;

        if (size >= 14 && size < 18)
        {
            spaces += 1;
        }
        else if (size >= 18 && size < 22)
        {
            spaces += 2;
        }
        else if (size >= 22 && size < 26)
        {
            spaces += 3;
        }
        else if (size >= 26 && size < 30)
        {
            spaces += 4;
        }
        else if (size >= 30 && size < 34)
        {
            spaces += 5;
        }
        else if (size >= 34 && size < 38)
        {
            spaces += 6;
        }
        else if (size >= 38 && size < 42)
        {
            spaces += 7;
        }
        else if (size >= 42 && size < 46)
        {
            spaces += 8;
        }
        else if (size >= 46 && size < 50)
        {
            spaces += 9;
        }
        else if (size >= 50 && size < 54)
        {
            spaces += 10;
        }
        else if (size >= 54 && size < 58)
        {
            spaces += 11;
        }
        else if (size >= 58 && size < 62)
        {
            spaces += 12;
        }
        else if (size >= 62 && size < 66)
        {
            spaces += 13;
        }
        else if (size >= 66 && size < 70)
        {
            spaces += 14;
        }
        else if (size >= 70 && size < 74)
        {
            spaces += 15;
        }
        else if (size >= 74 && size < 78)
        {
            spaces += 16;
        }
        else if (size >= 78 && size < 82)
        {
            spaces += 17;
        }
        else if (size >= 82 && size < 86)
        {
            spaces += 18;
        }
        else if (size >= 86 && size < 90)
        {
            spaces += 19;
        }
        else if (size >= 90 && size < 94)
        {
            spaces += 20;
        }
        else if (size >= 94 && size < 98)
        {
            spaces += 21;
        }

        Console.Write(' ');
        Console.Write(catsChar);
        Console.Write(new string(' ', spaces));
        Console.WriteLine(catsChar);

        for (int i = 0; i < spaces; i++)
        {
            Console.Write(' ');
            Console.WriteLine(new string(catsChar, spaces + 2));
        }

        for (int i = 0; i < spaces; i++)
        {
            Console.Write(' ');
            Console.Write(' ');
            Console.WriteLine(new string(catsChar, spaces));
        }

        for (int i = 0; i < spaces; i++)
        {
            Console.Write(' ');
            Console.WriteLine(new string(catsChar, spaces + 2));
        }

        Console.Write(' ');
        Console.Write(new string(catsChar, spaces + 2));
        if (size < 14)
        {
            Console.Write(new string(' ', spaces + 2));
        }
        else if (size >= 14 && size < 18)
        {
            Console.Write(new string(' ', spaces + 1));
        }
        else if (size >= 18 && size < 22)
        {
            Console.Write(new string(' ', spaces));
        }
        else if (size >= 22 && size < 26)
        {
            Console.Write(new string(' ', spaces - 1));
        }
        else if (size >= 26 && size < 30)
        {
            Console.Write(new string(' ', spaces - 2));
        }
        else if (size >= 30 && size < 34)
        {
            Console.Write(new string(' ', spaces - 3));
        }
        else if (size >= 34 && size < 38)
        {
            Console.Write(new string(' ', spaces - 4));
        }
        else if (size >= 38 && size < 42)
        {
            Console.Write(new string(' ', spaces - 5));
        }
        else if (size >= 42 && size < 46)
        {
            Console.Write(new string(' ', spaces - 6));
        }
        else if (size >= 46 && size < 50)
        {
            Console.Write(new string(' ', spaces - 7));
        }
        else if (size >= 50 && size < 54)
        {
            Console.Write(new string(' ', spaces - 8));
        }
        else if (size >= 54 && size < 58)
        {
            Console.Write(new string(' ', spaces - 9));
        }
        else if (size >= 58 && size < 62)
        {
            Console.Write(new string(' ', spaces - 10));
        }
        else if (size >= 62 && size < 66)
        {
            Console.Write(new string(' ', spaces - 11));
        }
        else if (size >= 66 && size < 70)
        {
            Console.Write(new string(' ', spaces - 12));
        }
        else if (size >= 70 && size < 74)
        {
            Console.Write(new string(' ', spaces - 13));
        }
        else if (size >= 74 && size < 78)
        {
            Console.Write(new string(' ', spaces - 14));
        }
        else if (size >= 78 && size < 82)
        {
            Console.Write(new string(' ', spaces - 15));
        }
        else if (size >= 82 && size < 86)
        {
            Console.Write(new string(' ', spaces - 16));
        }
        else if (size >= 86 && size < 90)
        {
            Console.Write(new string(' ', spaces - 17));
        }
        else if (size >= 90 && size < 94)
        {
            Console.Write(new string(' ', spaces - 18));
        }

        Console.WriteLine(new string(catsChar, spaces + 1));
        for (int i = 0; i < spaces + 2; i++)
        {
            Console.Write(new string(catsChar, spaces + 4));
            Console.Write(new string(' ', 2));
            Console.WriteLine(catsChar);
        }

        Console.Write(new string(catsChar, spaces + 4));
        Console.Write(' ');
        Console.WriteLine(new string(catsChar, 2));

        Console.Write(' ');
        Console.WriteLine(new string(catsChar, spaces + 5));
    }
}