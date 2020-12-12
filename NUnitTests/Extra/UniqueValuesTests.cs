using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class UniqueValuesTests
    {
        [TestCase(new int[] { 1, 1, 1, 2 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13 }, 7)]
        [TestCase(new int[] {  }, 0)]
        [TestCase(new int[] { -2, -1, -1, 0, 1 }, 4)]
        public void TestingCountUniqueValues(int[] arr, int expected)
        {
            var uniqueValues = new UniqueValues();

            var result = uniqueValues.CountUniqueValues(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
