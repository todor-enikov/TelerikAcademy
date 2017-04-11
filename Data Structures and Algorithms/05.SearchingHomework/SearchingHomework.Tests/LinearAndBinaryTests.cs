using System;
using NUnit.Framework;
using System.Text;

namespace SortingHomework.Tests
{
    [TestFixture]
    public class LinearAndBinaryTests
    {
        [Test]
        public void LinearSearch_ShouldReturnTrue_IfFindElementIntoGivenCollection()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            Assert.IsTrue(collection.LinearSearch(22));
        }

        [Test]
        public void LinearSearch_ShouldReturnFalse_IfDoesNotFindElementIntoGivenCollection()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            Assert.IsFalse(collection.LinearSearch(222));
        }

        [Test]
        public void BinarySearch_ShouldReturnTrue_IfFindElementIntoGivenCollection()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            Assert.IsTrue(collection.BinarySearch(11));
        }

        [Test]
        public void BinarySearch_ShouldReturnFalse_IfDoesNotFindElementIntoGivenCollection()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            Assert.IsFalse(collection.BinarySearch(23));
        }
    }
}
