namespace RotatingWalkInMatrix
{
    using System;

    public class PrintingFinalMatrix
    {
        public static void PrintingMatrix(int[,] field, int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write("{0,3}", field[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
