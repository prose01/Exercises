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

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 1, 1)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 99, null)]
        public void TestingBinarySearchTreeLookup(int[] arr, int lookup, object expected)
        {
            var Expected = new List<int>() { 10, 5, 16 };

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            var result = binarySearchTree.Lookup(lookup);

            Assert.AreEqual(expected, result?.Value);
        }


        // This is the tree we use in these tests.
        //                   9
        //             4             20
        //          1    6       15      170
        //             n   8   11  17  25   n
        //                7 n         n 150


        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 1)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 4)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 8, 7, 15, 170, 25, 150, 11, 17 }, 4)]
        public void TestingBinarySearchTreeRemove(int[] arr, int remove)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            binarySearchTree.Remove(remove);

            //Assert.AreEqual(expected, result?.Value);
        }
    }
}
