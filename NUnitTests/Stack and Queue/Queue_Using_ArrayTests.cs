using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Stack_and_Queue
{
    public class Queue_Using_ArrayTests
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void TestingQueue_Using_ArrayPush(int[] arr)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var queue_Using_Array = new Queue_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Array.Enqueue(arr[i]);
            }

            var result = queue_Using_Array.PrintQueue();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 })]
        public void TestingQueue_Using_ArrayPop(int[] arr)
        {
            var Expected = new List<int>() { 10, 99, 5, 16 };

            var queue_Using_Array = new Queue_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Array.Enqueue(arr[i]);
            }

            var lenght = queue_Using_Array.Dequeue();

            var result = queue_Using_Array.PrintQueue();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, false)]
        [TestCase(new int[] { }, true)]
        public void TestingQueue_Using_ArrayIsEmpty(int[] arr, bool Expected)
        {
            var queue_Using_Array = new Queue_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Array.Enqueue(arr[i]);
            }

            var result = queue_Using_Array.IsEmpty();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, "10")]
        public void TestingQueue_Using_ArrayPeek(int[] arr, string Expected)
        {
            var queue_Using_Array = new Queue_Using_Array();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Array.Enqueue(arr[i]);
            }

            var result = queue_Using_Array.Peek();

            Assert.AreEqual(Expected, result);
        }
    }
}
