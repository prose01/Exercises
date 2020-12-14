using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("qwertyuiopaq", 11)]
        public void TestingMaxSubArraySum(string input, int expected)
        {
            var sub = new LongestSubstringWithoutRepeatingCharacters();

            var result = sub.LengthOfLongestSubstring(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("qwertyuiopaq", 11)]
        public void TestingLengthOfLongestSubstringWindow(string input, int expected)
        {
            var sub = new LongestSubstringWithoutRepeatingCharacters();

            var result = sub.LengthOfLongestSubstringWindow(input);

            Assert.AreEqual(expected, result);
        }
    }
}
