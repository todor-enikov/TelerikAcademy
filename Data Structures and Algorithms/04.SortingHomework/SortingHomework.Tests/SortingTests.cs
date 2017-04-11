using System;
using NUnit.Framework;
using System.Text;

namespace SortingHomework.Tests
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void SelectionSort_ShouldSortGivenCollectionProperly_WithNumbers()
        {
            var sorter = new SelectionSorter<int>();
            var testedCollection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            testedCollection.Sort(sorter);

            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "0 11 22 33 101 101 ";

            Assert.AreEqual(expectedResult, result.ToString());
        }

        [Test]
        public void SelectionSort_ShouldSortGivenCollectionProperly_WithStrings()
        {
            var sorter = new SelectionSorter<string>();
            var testedCollection = new SortableCollection<string>(new[] { "Ivan", "Petyr", "Gosho", "Pencho", "Dragan" });
            testedCollection.Sort(sorter);
            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "Dragan Gosho Ivan Pencho Petyr ";

            Assert.AreEqual(expectedResult, result.ToString());
        }

        [Test]
        public void QuickSort_ShouldSortGivenCollectionProperly_WithNumbers()
        {
            var sorter = new Quicksorter<int>();
            var testedCollection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            testedCollection.Sort(sorter);

            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "0 11 22 33 101 101 ";

            Assert.AreEqual(expectedResult, result.ToString());
        }

        [Test]
        public void QuickSort_ShouldSortGivenCollectionProperly_WithStrings()
        {
            var sorter = new Quicksorter<string>();
            var testedCollection = new SortableCollection<string>(new[] { "Ivan", "Petyr", "Gosho", "Pencho", "Dragan" });
            testedCollection.Sort(sorter);
            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "Dragan Gosho Ivan Pencho Petyr ";

            Assert.AreEqual(expectedResult, result.ToString());
        }

        [Test]
        public void MergeSort_ShouldSortGivenCollectionProperly_WithNumbers()
        {
            var sorter = new MergeSorter<int>();
            var testedCollection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            testedCollection.Sort(sorter);

            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "0 11 22 33 101 101 ";

            Assert.AreEqual(expectedResult, result.ToString());
        }

        [Test]
        public void MergeSort_ShouldSortGivenCollectionProperly_WithStrings()
        {
            var sorter = new MergeSorter<string>();
            var testedCollection = new SortableCollection<string>(new[] { "Ivan", "Petyr", "Gosho", "Pencho", "Dragan" });
            testedCollection.Sort(sorter);
            var result = new StringBuilder();
            for (int i = 0; i < testedCollection.Items.Count; i++)
            {
                result.Append(testedCollection.Items[i]);
                result.Append(" ");
            }
            var expectedResult = "Dragan Gosho Ivan Pencho Petyr ";

            Assert.AreEqual(expectedResult, result.ToString());
        }
    }
}
