using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Stack_and_Queue
{
    public class Queue_Using_LinkedlistTests
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void TestingQueue_Using_LinkedlistPush(int[] arr)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var queue_Using_Linkedlist = new Queue_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Linkedlist.Enqueue(arr[i]);
            }

            var result = queue_Using_Linkedlist.PrintQueue();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 })]
        public void TestingQueue_Using_LinkedlistPop(int[] arr)
        {
            var Expected = new List<int>() {10, 99, 5, 16};

            var queue_Using_Linkedlist = new Queue_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Linkedlist.Enqueue(arr[i]);
            }

            var lenght = queue_Using_Linkedlist.Dequeue();

            var result = queue_Using_Linkedlist.PrintQueue();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, false)]
        [TestCase(new int[] { }, true)]
        public void TestingQueue_Using_LinkedlistIsEmpty(int[] arr, bool Expected)
        {
            var queue_Using_Linkedlist = new Queue_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Linkedlist.Enqueue(arr[i]);
            }

            var result = queue_Using_Linkedlist.IsEmpty();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, 10)]
        public void TestingQueue_Using_LinkedlistPeek(int[] arr, int Expected)
        {
            var queue_Using_Linkedlist = new Queue_Using_Linkedlist();

            for (int i = 0; i < arr.Length; i++)
            {
                queue_Using_Linkedlist.Enqueue(arr[i]);
            }

            var result = queue_Using_Linkedlist.Peek();

            Assert.AreEqual(Expected, result);
        }
    }
}
