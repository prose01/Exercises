using Exercises;
using NUnit.Framework;
using System;
using System.Globalization;

namespace NUnitTests.Extra
{
    public class CalendarTests
    {
        [TestCase("2020-01-01", "2020-01-07", 5)]
        [TestCase("2020-01-08", "2020-01-14", 5)]
        [TestCase("2020-01-08", "2020-01-21", 10)]
        [TestCase("2020-01-08", "2020-01-23", 12)]
        public void TestingBusinessDaysUntil(string startDate, string endDate, int expected)
        {
            var start = DateTime.ParseExact(startDate, "yyyy-MM-dd", new CultureInfo("en-US"));
            var end = DateTime.ParseExact(endDate, "yyyy-MM-dd", new CultureInfo("en-US"));

            var sut = new CalendarExercises();

            var result = sut.BusinessDaysUntil(start, end);

            Assert.AreEqual(expected, result);
        }

        [TestCase("2020-01-01", "2020-01-07", 5)]
        [TestCase("2020-01-08", "2020-01-14", 5)]
        [TestCase("2020-01-08", "2020-01-21", 10)]
        [TestCase("2020-01-08", "2020-01-23", 12)]
        public void TestingWorkingDays(string startDate, string endDate, int expected)
        {
            var start = DateTime.ParseExact(startDate, "yyyy-MM-dd", new CultureInfo("en-US"));
            var end = DateTime.ParseExact(endDate, "yyyy-MM-dd", new CultureInfo("en-US"));

            var sut = new CalendarExercises();

            var result = sut.WorkingDays(start, end);

            Assert.AreEqual(expected, result);
        }
    }
}
