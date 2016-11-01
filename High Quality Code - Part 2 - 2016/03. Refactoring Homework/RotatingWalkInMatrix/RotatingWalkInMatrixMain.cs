namespace RotatingWalkInMatrix
{
    using System;

    public class RotatingWalkInMatrixMain
    {
        public static void Main()
        {
            ////Console.WriteLine("Enter a positive number ");
            ////string input = Console.ReadLine();
            ////int number = 0;
            ////while (!int.TryParse(input, out number) || number < 0 || number > 100)
            ////{
            ////    Console.WriteLine("You haven't entered a correct positive number");
            ////    input = Console.ReadLine();
            ////}
            int number = 7;
            int[,] field = new int[number, number];
            int valueInCurrentCell = 1;
            int currentRow = 0;
            int currentColumn = 0;
            int increaseRow = 1;
            int increaseColumn = 1;
            MethodForFillingTheMatrix.FillingTheMatrix(field, currentRow, currentColumn, valueInCurrentCell, increaseRow, increaseColumn, number);
            PrintingFinalMatrix.PrintingMatrix(field, number);
        }

        
    }
}
