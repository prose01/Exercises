using Exercises;
using NUnit.Framework;

namespace NUnitTests.Sorting
{
    public class BubbleSortTests
    {
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 1, 4, 6, 9, 15, 20, 170 })]
        [TestCase(new int[] { 2, 4, 1, 3 }, new int[] { 1, 2, 3, 4 })]
        public void TestingBinarySearchTreeLookup(int[] arr, int[] expected)
        {
            var bubbleSort = new BubbleSort();

            var result = bubbleSort.Sort(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
