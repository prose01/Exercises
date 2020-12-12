using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class BinarySearchTests
    {
        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 20, 5)]
        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 6, 2)]
        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 15344, -1)]
        public void TestingBinarySearch(int[] arr, int lookup, object expected)
        {
            var binarySearch = new BinarySearch();

            var result = binarySearch.LinearSearch(arr, lookup);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 20, 5)]
        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 6, 2)]
        [TestCase(new int[] { 1, 4, 6, 9, 15, 20, 170 }, 15344, -1)]
        public void TestingBinarySearchDivideAndConquer(int[] arr, int lookup, object expected)
        {
            var binarySearch = new BinarySearch();

            var result = binarySearch.DivideAndConquer(arr, lookup);

            Assert.AreEqual(expected, result);
        }
    }
}
