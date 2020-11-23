using Exercises;
using NUnit.Framework;

namespace NUnitTests.Recursion
{
    public class FibonacciTests
    {
        [TestCase(2, 1)]
        [TestCase(6, 8)]
        [TestCase(8, 21)]
        public void TestingFibonacciRecursively(int number, int expected)
        {
            var fibonacci = new Fibonacci();

            var result = fibonacci.FibonacciRecursively(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 1, 0, 1)]
        [TestCase(6, 1, 0, 8)]
        [TestCase(8, 1, 0, 21)]
        public void TestingFibonacciRecursivelyEfficient(int number, int val, int prev, int expected)
        {
            var fibonacci = new Fibonacci();

            var result = fibonacci.FibonacciRecursivelyEfficient(number, val, prev);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 1)]
        [TestCase(6, 8)]
        [TestCase(8, 21)]
        public void TestingFibonacciIteratively(int number, int expected)
        {
            var fibonacci = new Fibonacci();

            var result = fibonacci.FibonacciIteratively(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 1)]
        [TestCase(6, 8)]
        [TestCase(8, 21)]
        public void TestingFibonacciIteratively2(int number, int expected)
        {
            var fibonacci = new Fibonacci();

            var result = fibonacci.FibonacciIteratively2(number);

            Assert.AreEqual(expected, result);
        }
    }
}
