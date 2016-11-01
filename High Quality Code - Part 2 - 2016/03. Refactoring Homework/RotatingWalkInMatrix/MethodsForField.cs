namespace RotatingWalkInMatrix
{
    using System;

    public static class MethodsForField
    {
        public static void ChangeIncreaseRowAndIncreaseColumnVariables(ref int increaseRow, ref int increaseColumn)
        {
            int[] valueForIncreaseRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] valueForIncreaseColumn = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int position = 0;
            for (int count = 0; count < 8; count++)
            {
                if (valueForIncreaseRow[count] == increaseRow &&
                    valueForIncreaseColumn[count] == increaseColumn)
                {
                    position = count;
                    break;
                }
            }

            if (position == 7)
            {
                increaseRow = valueForIncreaseRow[0];
                increaseColumn = valueForIncreaseColumn[0];
            }
            else
            {
                increaseRow = valueForIncreaseRow[position + 1];
                increaseColumn = valueForIncreaseColumn[position + 1];
            }
        }

        public static bool CheckForEmptyCells(int[,] field, int currentRow, int currentColumn)
        {
            int[] valueForIncreaseRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] valueForIncreaseColumn = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (currentRow + valueForIncreaseRow[i] >= field.GetLength(0) || currentRow + valueForIncreaseRow[i] < 0)
                {
                    valueForIncreaseRow[i] = 0;
                }

                if (currentColumn + valueForIncreaseColumn[i] >= field.GetLength(0) || currentColumn + valueForIncreaseColumn[i] < 0)
                {
                    valueForIncreaseColumn[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (field[currentRow + valueForIncreaseRow[i], currentColumn + valueForIncreaseColumn[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindNextEmptyCell(int[,] field, out int currentRow, out int currentColumn)
        {
            currentRow = 0;
            currentColumn = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    if (field[i, j] == 0)
                    {
                        currentRow = i;
                        currentColumn = j;
                        return;
                    }
                }
            }
        }
    }
}
