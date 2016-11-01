using System;
using NUnit.Framework;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestFixture]
    public class MethodsForFieldTests
    {
        [Test]
        public void ChangeIncreaseRowAndIncreaseColumnVariables_ShouldPassAndDoesNotThrowException_WhenPassedParametersAreValid()
        {
            int increaseRow = 1;
            int increaseColumn = 1;

            MethodsForField.ChangeIncreaseRowAndIncreaseColumnVariables(ref increaseRow, ref increaseColumn);

            Assert.Pass();
            Assert.DoesNotThrow(() => MethodsForField.ChangeIncreaseRowAndIncreaseColumnVariables(ref increaseRow, ref increaseColumn));
        }

        [Test]
        public void ChangeIncreaseRowAndIncreaseColumnVariables_ShouldUpdateIncreaseRowAndIncreaseColumn_WhenPassedParametersAreValidAndPositionIsEqualToSeven()
        {
            int increaseRow = -1;
            int increaseColumn = 1;
            MethodsForField.ChangeIncreaseRowAndIncreaseColumnVariables(ref increaseRow, ref increaseColumn);
            int expectedIncreaseRow = 1;
            int expectedIncreaseColumn = 1;

            Assert.AreEqual(expectedIncreaseRow, increaseRow + 1);
            Assert.AreEqual(expectedIncreaseColumn, increaseColumn);
        }

        [Test]
        public void CheckForEmptyCells_ShouldReturnTrue_IfValueInFieldCellIsZero()
        {
            int[,] field = new int[5, 5];
            int currentRow = 0;
            int currentColumn = 0;

            Assert.AreEqual(true, MethodsForField.CheckForEmptyCells(field, currentRow, currentColumn));
        }

        [Test]
        public void CheckForEmptyCells_ShouldReturnFalse_IfValueInFieldCellIsNotZero()
        {
            int[,] field = new int[5, 5];
            int currentRow = 0;
            int currentColumn = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 1;
                }
            }

            Assert.AreEqual(false, MethodsForField.CheckForEmptyCells(field, currentRow, currentColumn));
        }

        [Test]
        public void FindNextEmptyCell_ShouldPassAndDoesNotThrowException_WhenPassedParametersAreValid()
        {
            int[,] field = new int[5, 5];
            int currentRow = 0;
            int currentColumn = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 1;
                }
            }
            MethodsForField.FindNextEmptyCell(field, out currentRow, out currentColumn);

            Assert.Pass();
            Assert.DoesNotThrow(() => MethodsForField.FindNextEmptyCell(field, out currentRow, out currentColumn));
        }
    }
}
