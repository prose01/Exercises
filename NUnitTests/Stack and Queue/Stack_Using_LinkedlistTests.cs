using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.LinkedList
{
    public class Stack_Using_LinkedlistTests
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void Testingstack_Using_LinkedlistPush(int[] arr)
        {
            var Expected = new List<int>() { 16, 5, 10 };

            var stack_Using_Linkedlist = new Stack_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Linkedlist.Push(arr[i]);
            }

            var result = stack_Using_Linkedlist.PrintStack();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 })]
        public void Testingstack_Using_LinkedlistPop(int[] arr)
        {
            var Expected = new List<int>() { 5, 99, 10, 1 };

            var stack_Using_Linkedlist = new Stack_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Linkedlist.Push(arr[i]);
            }

            var lenght = stack_Using_Linkedlist.Pop();

            var result = stack_Using_Linkedlist.PrintStack();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, false)]
        [TestCase(new int[] { }, true)]
        public void Testingstack_Using_LinkedlistIsEmpty(int[] arr, bool Expected)
        {
            var stack_Using_Linkedlist = new Stack_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Linkedlist.Push(arr[i]);
            }

            var result = stack_Using_Linkedlist.IsEmpty();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, 16)]
        public void Testingstack_Using_LinkedlistPeek(int[] arr, int Expected)
        {
            var stack_Using_Linkedlist = new Stack_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                stack_Using_Linkedlist.Push(arr[i]);
            }

            var result = stack_Using_Linkedlist.Peek();

            Assert.AreEqual(Expected, result);
        }
    }
}
