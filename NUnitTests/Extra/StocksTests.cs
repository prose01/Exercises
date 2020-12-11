using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class StocksTests
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void TestingMaxProfit(int[] nums, int expected)
        {
            var stocks = new Stocks();

            var result = stocks.MaxProfit(nums);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void TestingMaxProfit2(int[] nums, int expected)
        {
            var stocks = new Stocks();

            var result = stocks.MaxProfit2(nums);

            Assert.AreEqual(expected, result);
        }
    }
}
