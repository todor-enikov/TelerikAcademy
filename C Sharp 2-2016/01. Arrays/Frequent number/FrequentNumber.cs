using System;

class FrequentNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arraySequence = new int[number];
        int currentCounter = 0;
        int finalCounter = 0;
        int index = 0;

        for (int i = 0; i < arraySequence.Length; i++)
        {
            arraySequence[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySequence.Length; i++)
        {
            for (int j = 0; j < arraySequence.Length; j++)
            {
                if (arraySequence[i] == arraySequence[j])
                {
                    currentCounter++;
                }
            }

            if (currentCounter > finalCounter)
            {
                index = i;
                finalCounter = currentCounter;
            }
            currentCounter = 0;
        }

        Console.WriteLine("{0} ({1} times)", arraySequence[index], finalCounter);
    }
}

