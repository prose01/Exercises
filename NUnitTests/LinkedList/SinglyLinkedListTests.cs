using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.LinkedList
{
    public class SinglyLinkedListTests
    {
        [TestCase(new int[] { 10, 5, 16 })]
        public void TestingSinglyLinkedListAppend(int[] arr)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var singlyLinkedList = new SinglyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                singlyLinkedList.Append(arr[i]);
            }

            var result = singlyLinkedList.PrintLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 10, 5, 16 }, 1)]
        public void TestingSinglyLinkedListPrepend(int[] arr, int prepend)
        {
            var Expected = new List<int>() { 1, 10, 5, 16 };

            var singlyLinkedList = new SinglyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                singlyLinkedList.Append(arr[i]);
            }

            singlyLinkedList.Prepend(prepend);

            var result = singlyLinkedList.PrintLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 5, 16 }, 2, 99)]
        public void TestingSinglyLinkedListInsert(int[] arr, int index, int insert)
        {
            var Expected = new List<int>() { 1, 10, 99, 5, 16 };

            var singlyLinkedList = new SinglyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                singlyLinkedList.Append(arr[i]);
            }

            singlyLinkedList.Insert(index, insert);

            var result = singlyLinkedList.PrintLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 5, 16 }, 200, 99)]
        public void TestingSinglyLinkedListInsertIndexTooHigh(int[] arr, int index, int insert)
        {
            var Expected = new List<int>() { 1, 10, 5, 16, 99 };

            var singlyLinkedList = new SinglyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                singlyLinkedList.Append(arr[i]);
            }

            singlyLinkedList.Insert(index, insert);

            var result = singlyLinkedList.PrintLinkedList();

            Assert.AreEqual(Expected, result);
        }

        [TestCase(new int[] { 1, 10, 99, 5, 16 }, 2)]
        public void TestingSinglyLinkedListRemove(int[] arr, int index)
        {
            var Expected = new List<int>() { 1, 10, 5, 16 };

            var singlyLinkedList = new SinglyLinkedList(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                singlyLinkedList.Append(arr[i]);
            }

            singlyLinkedList.Remove(index);

            var result = singlyLinkedList.PrintLinkedList();

            Assert.AreEqual(Expected, result);
        }
    }
}
