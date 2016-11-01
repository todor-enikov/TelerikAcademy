namespace RotatingWalkInMatrix
{
    using System;

    public class MethodForFillingTheMatrix
    {
        public static void FillingTheMatrix(int[,] field, int currentRow, int currentColumn, int valueInCurrentCell, int increaseRow, int increaseColumn, int number)
        {
            while (true)
            {
                field[currentRow, currentColumn] = valueInCurrentCell;
                if (!MethodsForField.CheckForEmptyCells(field, currentRow, currentColumn))
                {
                    break;
                }

                if (currentRow + increaseRow >= number || currentRow + increaseRow < 0 || currentColumn + increaseColumn >= number || currentColumn + increaseColumn < 0 || field[currentRow + increaseRow, currentColumn + increaseColumn] != 0)
                {
                    while (currentRow + increaseRow >= number || currentRow + increaseRow < 0 || currentColumn + increaseColumn >= number || currentColumn + increaseColumn < 0 || field[currentRow + increaseRow, currentColumn + increaseColumn] != 0)
                    {
                        MethodsForField.ChangeIncreaseRowAndIncreaseColumnVariables(ref increaseRow, ref increaseColumn);
                    }
                }

                currentRow += increaseRow;
                currentColumn += increaseColumn;
                valueInCurrentCell++;
            }

            MethodsForField.FindNextEmptyCell(field, out currentRow, out currentColumn);
            valueInCurrentCell++;

            if (currentRow != 0 && currentColumn != 0)
            {
                while (true)
                {
                    field[currentRow, currentColumn] = valueInCurrentCell;
                    if (!MethodsForField.CheckForEmptyCells(field, currentRow, currentColumn))
                    {
                        break;
                    }

                    if (currentRow + increaseRow >= number || currentRow + increaseRow < 0 || currentColumn + increaseColumn >= number || currentColumn + increaseColumn < 0 || field[currentRow + increaseRow, currentColumn + increaseColumn] != 0)
                    {
                        while (currentRow + increaseRow >= number || currentRow + increaseRow < 0 || currentColumn + increaseColumn >= number || currentColumn + increaseColumn < 0 || field[currentRow + increaseRow, currentColumn + increaseColumn] != 0)
                        {
                            MethodsForField.ChangeIncreaseRowAndIncreaseColumnVariables(ref increaseRow, ref increaseColumn);
                        }
                    }

                    currentRow += increaseRow;
                    currentColumn += increaseColumn;
                    valueInCurrentCell++;
                }
            }
        }
    }
}
