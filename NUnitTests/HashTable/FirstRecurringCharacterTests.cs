using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Exercises;

namespace NUnitTests.HashTable
{
    public class FirstRecurringCharacterTests
    {
        [TestCase(new int[] { 1, 5, 8, 5, 1, 8, 8, 7, 4, 4, 10 }, ExpectedResult = 5)]
        [TestCase(new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 }, ExpectedResult = 1)]
        [TestCase(new int[] { 2, 3, 4, 5 }, ExpectedResult = 0)]
        public int TestingFirstRecurringCharacter(int[] arr)
        {
            var firstRecurringCharacter = new FirstRecurringCharacter();

            return firstRecurringCharacter.FindFirstRecurringChar(arr);
        }
    }
}
