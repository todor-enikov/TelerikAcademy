using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 2; i--)
        {
            bool prime = IsPrime(i);
            if (prime)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
    static bool IsPrime(int value)
    {
        if (value == 0 || value == 1)
        {
            return false;
        }
        else
        {
            for (int a = 2; a <= value / 2; a++)
            {
                if (value % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}