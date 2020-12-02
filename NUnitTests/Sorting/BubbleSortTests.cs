using Exercises;
using NUnit.Framework;

namespace NUnitTests.Sorting
{
    public class BubbleSortTests
    {
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 1, 4, 6, 9, 15, 20, 170 })]
        [TestCase(new int[] { 2, 4, 1, 3 }, new int[] { 1, 2, 3, 4 })]
        public void TestingBubbleSort(int[] arr, int[] expected)
        {
            var bubbleSort = new BubbleSort();

            var result = bubbleSort.Sort(arr);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 170, 20, 15, 9, 6, 4, 1 })]
        [TestCase(new int[] { 2, 4, 1, 3 }, new int[] { 4, 3, 2, 1 })]
        public void TestingBubbleSortDesc(int[] arr, int[] expected)
        {
            var bubbleSort = new BubbleSort();

            var result = bubbleSort.SortDesc(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
