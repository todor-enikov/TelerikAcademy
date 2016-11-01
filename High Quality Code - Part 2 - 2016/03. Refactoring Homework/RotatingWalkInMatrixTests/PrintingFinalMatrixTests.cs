using System;
using NUnit.Framework;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestFixture]
    public class PrintingFinalMatrixTests
    {
        [Test]
        public void PrintingFinalMatrix_ShouldPrintMatrix_WhenPassedParametersAreValid()
        {
            int number = 5;
            int[,] field = new int[number, number];

            Assert.DoesNotThrow(() => PrintingFinalMatrix.PrintingMatrix(field, number));
        }
    }
}
