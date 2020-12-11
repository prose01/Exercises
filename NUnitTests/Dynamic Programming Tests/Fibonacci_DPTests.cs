using Exercises;
using NUnit.Framework;

namespace NUnitTests.Dynamic_Programming_Tests
{
    public class Fibonacci_DPTests
    {
        [TestCase(2, 1)]
        [TestCase(6, 8)]
        [TestCase(8, 21)]
        [TestCase(12, 144)]
        public void TestingFibonacciMaster(int number, int expected)
        {
            var fibonacci_DP = new Fibonacci_DP();

            var result = fibonacci_DP.FibonacciMaster(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 1)]
        [TestCase(6, 8)]
        [TestCase(8, 21)]
        [TestCase(12, 144)]
        public void TestingFibonacciButtomUp(int number, int expected)
        {
            var fibonacci_DP = new Fibonacci_DP();

            var result = fibonacci_DP.FibonacciButtomUp(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3, 1 }, 4)]
        [TestCase(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void TestingHouseRobber(int[] nums, int expected)
        {
            var fibonacci_DP = new Fibonacci_DP();

            var result = fibonacci_DP.HouseRobber(nums);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3, 1 }, 4)]
        [TestCase(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void TestingRob(int[] nums, int expected)
        {
            var fibonacci_DP = new Fibonacci_DP();

            var result = fibonacci_DP.Rob(nums);

            Assert.AreEqual(expected, result);
        }
    }
}
