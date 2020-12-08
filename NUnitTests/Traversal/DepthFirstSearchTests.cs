using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTests.Traversal
{
    public class DepthFirstSearchTests
    {
        // This is the tree we use in these tests.
        //           9
        //    4             20
        //  1   6       15      170

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 1, 4, 6, 9, 15, 20, 170 })]
        public void TestingDFSInOrder(int[] arr, int[] expected)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            List<int> list = new List<int>();
            var depthFirstSearch = new DepthFirstSearch();
            var result = depthFirstSearch.DFSInOrder(binarySearchTree.root, list);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 9, 4, 1, 6, 20, 15, 170 })]
        public void TestingDFSPreOrder(int[] arr, int[] expected)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            List<int> list = new List<int>();
            var depthFirstSearch = new DepthFirstSearch();
            var result = depthFirstSearch.DFSPreOrder(binarySearchTree.root, list);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 9, 4, 20, 1, 6, 15, 170 }, new int[] { 1, 6, 4, 15, 170, 20, 9 })]
        public void TestingDFSPostOrder(int[] arr, int[] expected)
        {
            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < arr.Length; i++)
            {
                binarySearchTree.Insert(arr[i]);
            }

            List<int> list = new List<int>();
            var depthFirstSearch = new DepthFirstSearch();
            var result = depthFirstSearch.DFSPostOrder(binarySearchTree.root, list);

            Assert.AreEqual(expected, result);
        }
    }
}
