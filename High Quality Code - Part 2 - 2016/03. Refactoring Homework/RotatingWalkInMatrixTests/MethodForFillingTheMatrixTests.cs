using System;
using NUnit.Framework;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestFixture]
    public class MethodForFillingTheMatrixTests
    {
        [Test]
        public void FillingTheMatrix_ShouldFillTheMatrixCorrectly_WhenPassedParametersAreCorrect()
        {
            int number = 7;
            int[,] field = new int[number, number];
            int valueInCurrentCell = 1;
            int currentRow = 0;
            int currentColumn = 0;
            int increaseRow = 1;
            int increaseColumn = 1;

            Assert.DoesNotThrow(() => MethodForFillingTheMatrix.FillingTheMatrix(field, currentRow, currentColumn, valueInCurrentCell, increaseRow, increaseColumn, number));
        }
    }
}
