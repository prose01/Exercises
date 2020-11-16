using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.LinkedList
{
    public class DoublyLinkedListTests
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void TestingDoublyLinkedListAppend(int[] arr)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, 1)]
        public void TestingDoublyLinkedListPrepend(int[] arr, int prepend)
        {
            var Expected = new List<int>() { 1, 10, 5, 16 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Prepend(prepend);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 5, 16 }, 2, 99)]
        public void TestingDoublyLinkedListInsert(int[] arr, int index, int insert)
        {
            var Expected = new List<int>() { 1, 10, 99, 5, 16 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Insert(index, insert);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 5, 16 }, 200, 99)]
        public void TestingDoublyLinkedListIndexTooHigh(int[] arr, int index, int insert)
        {
            var Expected = new List<int>() { 1, 10, 5, 16, 99 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Insert(index, insert);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 }, 2)]
        public void TestingDoublyLinkedListRemove(int[] arr, int index)
        {
            var Expected = new List<int>() { 1, 10, 5, 16 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Remove(index);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1 }, 2)]
        public void TestingDoublyLinkedListRemoveShortList(int[] arr, int index)
        {
            var Expected = new List<int>() { 1 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Remove(index);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 }, 0)]
        public void TestingDoublyLinkedListRemoveHead(int[] arr, int index)
        {
            var Expected = new List<int>() { 10, 99, 5, 16 };

            var doublyLinkedList = new DoublyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                doublyLinkedList.Append(arr[i]);
            }

            doublyLinkedList.Remove(index);

            var result = doublyLinkedList.PrintDoublyLinkedList();

            Assert.AreEqual(Expected, result);
        }
    }
}
