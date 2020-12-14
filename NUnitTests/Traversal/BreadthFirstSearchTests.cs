using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Traversal
{
    public class BreadthFirstSearchTests
    {
        // This is the tree we use in these tests.
        //           9
        //    4             20
        //  1   6       15      170

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 9, 4, 20, 1, 6, 15, 170 })]
        public void TestingBreathFirstSearch(int[] arr, int[] expected)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            var breadthFirstSearch = new BreadthFirstSearch();
            var result = breadthFirstSearch.BreathFirstSearch(binarySearchTree.root);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 9, 4, 20, 1, 6, 15, 170 })]
        public void TestingBreathFirstSearchRecurcive(int[] arr, int[] expected)
        {
            //var Expected = new List<int>() { 9, 4, 20, 1, 6, 15, 170 };

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            List<int> list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(binarySearchTree.root);

            var breadthFirstSearch = new BreadthFirstSearch();
            var result = breadthFirstSearch.BreathFirstSearchRecurcive(queue, list);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 1, true)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 15, true)]
        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, 77, false)]
        public void TestingLookup(int[] arr, int lookup, bool expected)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            var sut = new BreadthFirstSearch();
            var result = sut.Lookup(binarySearchTree.root, lookup);

            Assert.AreEqual(expected, result);
        }
    }
}
