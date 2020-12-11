using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class HouseRobberTests
    {

        [TestCase(new int[] { 1, 2, 3, 1 }, 4)]
        [TestCase(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void TestingHouseRobber(int[] nums, int expected)
        {
            var houseRobber = new HouseRobber();

            var result = houseRobber.MyRobber(nums);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3, 1 }, 4)]
        [TestCase(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void TestingRob(int[] nums, int expected)
        {
            var houseRobber = new HouseRobber();

            var result = houseRobber.Rob(nums);

            Assert.AreEqual(expected, result);
        }
    }
}
