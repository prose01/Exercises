using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class StairsTests
    {
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        public void TestingClimbStairs(int steps, int expected)
        {
            var stairs = new Stairs();

            var result = stairs.ClimbStairs(steps);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        public void TestinClimbStairsMemoization(int steps, int expected)
        {
            var stairs = new Stairs();

            var result = stairs.ClimbStairsMemoization(steps);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        public void TestinClimbStairsFibonacci(int steps, int expected)
        {
            var stairs = new Stairs();

            var result = stairs.ClimbStairsFibonacci(steps);

            Assert.AreEqual(expected, result);
        }
    }
}
