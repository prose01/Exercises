using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class PalindromeNumberTests
    {
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(1234, false)]
        [TestCase(1234321, true)]
        public void TestingIsPalindrome(int num, bool expected)
        {
            var palindromeNumber = new PalindromeNumber();

            var result = palindromeNumber.IsPalindrome(num);

            Assert.AreEqual(expected, result);
        }

        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(1234, false)]
        [TestCase(1234321, true)]
        public void TestingIsPalindromeX(int num, bool expected)
        {
            var palindromeNumber = new PalindromeNumber();

            var result = palindromeNumber.IsPalindromeX(num);

            Assert.AreEqual(expected, result);
        }
    }
}
