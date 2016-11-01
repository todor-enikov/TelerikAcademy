using System;
using NUnit.Framework;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestFixture]
    public class RotatingWalkInMatrixMainTests
    {
        [Test]
        public void RotatingInMatrixMain_ShouldPassIfTheGivenParameteresAreValid()
        {
            Assert.DoesNotThrow(() => RotatingWalkInMatrixMain.Main());
        }
    }
}
