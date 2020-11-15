using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exercises;

namespace NUnitTests.Array
{
    public class ContainsCommonItemTests
    {
        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'x' }, ExpectedResult = true)]
        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'i' }, ExpectedResult = false)]
        public bool TestingContainsCommonItem(char[] arr1, char[] arr2)
        {
            var containsCommonItem = new ContainsCommonItem();

            return containsCommonItem.containsCommonItem(arr1, arr2);
        }

        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'x' }, ExpectedResult = true)]
        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'i' }, ExpectedResult = false)]
        public bool TestingContainsCommonItem2(char[] arr1, char[] arr2)
        {
            var containsCommonItem = new ContainsCommonItem();

            return containsCommonItem.containsCommonItem2(arr1, arr2);
        }

        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'x' }, ExpectedResult = true)]
        [TestCase(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'i' }, ExpectedResult = false)]
        public bool TestingContainsCommonItem3(char[] arr1, char[] arr2)
        {
            var containsCommonItem = new ContainsCommonItem();

            return containsCommonItem.containsCommonItem3(arr1, arr2);
        }
    }
}
