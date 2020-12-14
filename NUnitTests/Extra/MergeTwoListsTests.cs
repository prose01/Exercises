using Exercises;
using NUnit.Framework;

namespace NUnitTests.Extra
{
    public class MergeTwoListsTests
    {
        [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        public void TestingMergeTwoNodes(int[] l1, int[] l2, object expected)
        {
            var sut = new MergeTwoLists();

            var list1 = sut.CreateNode(l1);
            var list2 = sut.CreateNode(l2);

            var result = sut.MergeTwoNodes(list1, list2);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        public void TestingMergeTwoLists(int[] l1, int[] l2, object expected)
        {
            var sut = new MergeTwoLists();

            var result = sut.MergeTwoLists2(l1, l2);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        public void TestingMergeTwoListsAnswer(int[] l1, int[] l2, object expected)
        {
            var sut = new MergeTwoLists();

            var list1 = sut.CreateNode(l1);
            var list2 = sut.CreateNode(l2);

            var tempResult = sut.MergeTwoListsAnswer(list1, list2);

            var result = sut.PrintLinkedList(tempResult);

            Assert.AreEqual(expected, result);
        }
    }
}
