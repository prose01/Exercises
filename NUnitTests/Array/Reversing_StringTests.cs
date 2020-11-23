using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exercises;

namespace NUnitTests.Array
{
    public class Reversing_StringTests
    {
        [TestCase("I am Peter", ExpectedResult = "reteP ma I")]
        [TestCase("Hello World", ExpectedResult = "dlroW olleH")]
        public string TestingReverseString(string str)
        {
            var reversing_String = new Reversing_String();

            return reversing_String.ReverseString(str);
        }

        [TestCase("I am Peter", ExpectedResult = "reteP ma I")]
        [TestCase("Hello World", ExpectedResult = "dlroW olleH")]
        public string TestingReverseStringFaster(string str)
        {
            var reversing_String = new Reversing_String();

            return reversing_String.ReverseStringFaster(str);
        }
    }
}
