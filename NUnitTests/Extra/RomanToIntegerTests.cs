using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class RomanToIntegerTests
    {
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VIII", 8)]
        [TestCase("XIV", 14)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        [TestCase("MCMXCIX", 1999)]
        [TestCase("MMCDXLIV", 2444)]
        [TestCase("MMMMDCCCLXXXVIII", 4888)]
        public void Test_RomanToInteger(string input, int result)
        {
            // Arrange
            var sut = new RomanToInteger();

            // Act
            int number = sut.RomanToIntegerConverter(input);

            // Assert
            Assert.AreEqual(number, result);
        }

        [TestCase(5, "V")]
        [TestCase(90, "XC")]
        [TestCase(1999, "MCMXCIX")]
        [TestCase(2444, "MMCDXLIV")]
        public void Test_IntegerToRoman(int input, string result)
        {
            // Arrange
            var sut = new RomanToInteger();

            // Act
            string number = sut.IntegerToRomanConverter(input);

            // Assert
            Assert.AreEqual(number, result);
        }

        //[TestCase("IIII")]
        //[TestCase("VVVV")]
        //[TestCase("XXXX")]
        //[TestCase("CCCC")]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test_MaxThreeSimilarValues_ExpectedException(string value)
        //{
        //    // Arrange
        //    var sut = new RomanToInteger();

        //    // Act
        //    int number = sut.RomanToIntegerConverter(value);
        //}

        //[TestCase("IL")]
        //[TestCase("IC")]
        //[TestCase("ID")]
        //[TestCase("IM")]
        //[TestCase("XD")]
        //[TestCase("XM")]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test_ProhibitedLargeBeforeSmallValues_ExpectedException(string value)
        //{
        //    // Arrange
        //    var sut = new RomanToInteger();

        //    // Act
        //    int number = sut.RomanToIntegerConverter(value);
        //}

        //[TestCase("IIV")]
        //[TestCase("VVX")]
        //[TestCase("XXL")]
        //[TestCase("LLC")]
        //[TestCase("CCD")]
        //[TestCase("DDM")]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test_TwoConsecutiveSmallValuesBeforeLarge_ExpectedException(string value)
        //{
        //    // Arrange
        //    var sut = new RomanToInteger();

        //    // Act
        //    int number = sut.RomanToIntegerConverter(value);
        //}

        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test_MaxValue3000()
        //{
        //    // Arrange
        //    var sut = new RomanToInteger();

        //    // Act
        //    string number = sut.IntegerToRomanConverter(3000);
        //}
    }
}
