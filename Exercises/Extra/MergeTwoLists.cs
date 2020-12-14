using System.Collections.Generic;

namespace Exercises
{
    public class MergeTwoLists
    {
        // https://leetcode.com/problems/merge-two-sorted-lists/
        // Merge two sorted linked lists and return it as a new sorted list. The new list should be made by splicing together the nodes of the first two lists.

        public int[] MergeTwoNodes(ListNode l1, ListNode l2) // My cheat answer - using PrintLinkedList to create an array that I can them merge like MergeSort.
        {
            List<int> result = new List<int>();

            int[] list1 = this.PrintLinkedList(l1);
            int[] list2 = this.PrintLinkedList(l2);

            int index1 = 0;
            int index2 = 0;

            while (index1 < list1.Length || index2 < list2.Length)
            {
                // check if left and right are empty. If not compare them otherwise just add the new value.
                if (index1 < list1.Length && index2 < list2.Length)
                {
                    if (list1[index1] < list2[index2])
                    {
                        result.Add(list1[index1]);
                        index1++;
                    }
                    else
                    {
                        result.Add(list2[index2]);
                        index2++;
                    }
                }
                else if (index1 < list1.Length)
                {
                    result.Add(list1[index1]);
                    index1++;
                }
                else if (index2 < list2.Length)
                {
                    result.Add(list2[index2]);
                    index2++;
                }
            }

            return result.ToArray();
        }

        public int[] MergeTwoLists2(int[] l1, int[] l2) // This is MergeSort
        {
            List<int> result = new List<int>();

            int index1 = 0;
            int index2 = 0;

            while(index1 < l1.Length || index2 < l2.Length)
            {
                // check if left and right are empty. If not compare them otherwise just add the new value.
                if (index1 < l1.Length && index2 < l2.Length)
                {
                    if (l1[index1] < l2[index2])
                    {
                        result.Add(l1[index1]);
                        index1++;
                    }
                    else
                    {
                        result.Add(l2[index2]);
                        index2++;
                    }
                }
                else if (index1 < l1.Length)
                {
                    result.Add(l1[index1]);
                    index1++;
                }
                else if (index2 < l2.Length)
                {
                    result.Add(l2[index2]);
                    index2++;
                }
            }


            return result.ToArray();
        }


        public ListNode CreateNode(int[] list)
        {
            ListNode node = new ListNode(list[0]);
            ListNode tail = node;

            for (var i = 1; i < list.Length; i++)
            {
                var newNode = new ListNode(list[i]);
                tail.next = newNode;
                tail = newNode;
            }

            return node;
        }

        public int[] PrintLinkedList(ListNode node)
        {
            var linkedList = new List<int>();

            if (node == null)
            {
                return linkedList.ToArray();
            }

            var currentNode = node;

            while (currentNode != null)
            {
                linkedList.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            return linkedList.ToArray();

        }

        public class ListNode // Teachers node.
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        //public class Node // My node.
        //{
        //    public int Value { get; set; }
        //    public Node Next { get; set; }

        //    public Node(int value)
        //    {
        //        this.Value = value;
        //        this.Next = null;
        //    }
        //}


        public ListNode MergeTwoListsAnswer(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;

            ListNode result = new ListNode();
            ListNode current = result;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            // If one ListNode is larger than the other.
            if (l1 != null)
                current.next = l1;

            if (l2 != null)
                current.next = l2;

            return result.next;
        }
    }
}
