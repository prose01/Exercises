using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Recursion
{
    class FactorialTest
    {
        [TestCase(5, 120)]
        public void TestingFindFactorialRecursively(int number, int expected)
        {
            var factorial = new Factorial();

            var result = factorial.FindFactorialRecursively(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(5, 120)]
        public void TestingFindFactorialIteratively(int number, int expected)
        {
            var factorial = new Factorial();

            var result = factorial.FindFactorialIteratively(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(5, 120)]
        public void TestingFact(int number, int expected)
        {
            var factorial = new Factorial();

            var result = factorial.Fact(number);

            Assert.AreEqual(expected, result);
        }
    }
}
