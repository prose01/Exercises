using Exercises;
using NUnit.Framework;

namespace NUnitTests.Sorting
{
    public class MergeSortTests
    {
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 1, 4, 6, 9, 15, 20, 170 })]
        [TestCase(new int[] { 4, 2, 1, 3 }, new int[] { 1, 2, 3, 4 })]
        public void TestingInsertionSort(int[] arr, int[] expected)
        {
            var mergeSort = new MergeSort();

            var result = mergeSort.Sort(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
