using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class SubArraySumTests
    {
        [TestCase(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 2, 10)]
        [TestCase(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 4, 17)]
        [TestCase(new int[] { 4, 2, 1, 6 }, 1, 6)]
        [TestCase(new int[] { 4, 2, 1, 6, 2 }, 4, 13)]
        [TestCase(new int[] { }, 4, 0)]
        public void TestingMaxSubArraySum(int[] arr, int n, int expected)
        {
            var subArraySum = new SubArraySum();

            var result = subArraySum.MaxSubArraySum2(arr, n);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 2, 10)]
        [TestCase(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 4, 17)]
        [TestCase(new int[] { 4, 2, 1, 6 }, 1, 6)]
        [TestCase(new int[] { 4, 2, 1, 6, 2 }, 4, 13)]
        [TestCase(new int[] { }, 4, 0)]
        public void TestingMaxSubArraySumSlidingWindow(int[] arr, int n, int expected)
        {
            var subArraySum = new SubArraySum();

            var result = subArraySum.MaxSubArraySumSlidingWindow(arr, n);

            Assert.AreEqual(expected, result);
        }
    }
}
