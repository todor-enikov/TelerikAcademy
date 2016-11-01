using System;

class CompareChar
{
    static void Main()
    {
        string firstArray = Console.ReadLine();
        char[] firstCharArray = firstArray.ToCharArray();
        string secondArray = Console.ReadLine();
        char[] secondCharArray = secondArray.ToCharArray();
        int counter = 0;

        if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine(">");
        }
        else if (firstCharArray.Length < secondCharArray.Length)
        {
            Console.WriteLine("<");
        }
        else if (firstCharArray.Length == secondCharArray.Length)
        {
            for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if (firstCharArray[i] < secondCharArray[i])
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (firstCharArray[i] == secondCharArray[i])
                {
                    counter++;
                    if (counter == firstCharArray.Length)
                    {
                        Console.WriteLine("=");
                    }
                }

            }
        }
    }
}
