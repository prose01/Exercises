using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Stack_and_Queue
{
    public class Stack_Using_ArrayTest
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void TestingStack_Using_ArrayPush(int[] arr)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var stack_Using_Array = new Stack_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Array.Push(arr[i]);
            }

            var result = stack_Using_Array.PrintStack();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 })]
        public void TestingStack_Using_ArrayPop(int[] arr)
        {
            var Expected = new List<int>() { 1, 10, 99, 5 };

            var stack_Using_Array = new Stack_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Array.Push(arr[i]);
            }

            var lenght = stack_Using_Array.Pop();

            var result = stack_Using_Array.PrintStack();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, false)]
        [TestCase(new int[] { }, true)]
        public void TestingStack_Using_ArrayIsEmpty(int[] arr, bool Expected)
        {
            var stack_Using_Array = new Stack_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Array.Push(arr[i]);
            }

            var result = stack_Using_Array.IsEmpty();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, "16")]
        public void TestingStack_Using_ArrayPeek(int[] arr, string Expected)
        {
            var stack_Using_Array = new Stack_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Array.Push(arr[i]);
            }

            var result = stack_Using_Array.Peek();

            Assert.AreEqual(Expected, result);
        }
    }
}
