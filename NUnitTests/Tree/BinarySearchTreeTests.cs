using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Tree
{
    public class BinarySearchTreeTests
    {
        // This is the tree we use in these tests.
        //           9
        //    4             20
        //  1   6       15      170

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 })]
        public void TestingBinarySearchTreeInsert(int[] arr)
        {
            //var Expected = new List<int>() { 9, 4, 20, 1, 6, 15, 170 };

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            //var result = binarySearchTree.PrintLinkedList();

            //Assert.AreEqual(Expected, null);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 1, true)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 99, false)]
        public void TestingBinarySearchTreeLookup(int[] arr, int lookup, bool expected)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            var result = binarySearchTree.Lookup(lookup);

            Assert.AreEqual(expected, result);
        }
    }
}
