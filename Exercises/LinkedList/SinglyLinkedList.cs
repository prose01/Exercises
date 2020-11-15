using System.Collections.Generic;

namespace Exercises
{
    // Create the below linked list:
    // myLinkedList = {
    //   head: {
    //     value: 10
    //     next: {
    //       value: 5
    //       next: {
    //         value: 16
    //         next: null
    //       }
    //     }
    //   }
    // };

    public class SinglyLinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public SinglyLinkedList(int value)
        {
            this.head = new Node(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void Append(int value)
        {
            var newNode = new Node(value);
            this.tail.next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            var newNode = new Node(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length++;

        }

        public void Insert(int index, int value)
        {
            if (index == 0)
            {
                this.Prepend(value);
                return; // let's just get out of here.
            }

            if (index >= this.length)
            {
                this.Append(value);
                return; // let's just get out of here.
            }

            var newNode = new Node(value);

            var leader = this.TraverseToIndex(index - 1);

            newNode.next = leader.next; // Insert everythign after the slice into the new node.

            leader.next = newNode; // Simply add the new node where we sliced the old list.

            this.length++;
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                this.head = this.head.next;
                return; // let's just get out of here.
            }

            var leader = this.TraverseToIndex(index - 1);

            var removedNode = leader.next;

            leader.next = removedNode.next;
            this.length--;
        }


        /// <summary>Traverses to index. Where we slice the linkedList.</summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        private Node TraverseToIndex(int index)
        {
            int counter = 0;

            var currentNode = this.head;

            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }

            return currentNode;
        }

        public List<int> PrintLinkedList()
        {
            var linkedList = new List<int>();

            if (this.head == null)
            {
                return linkedList;
            }

            var currentNode = this.head;

            while (currentNode != null)
            {
                linkedList.Add(currentNode.value);
                currentNode = currentNode.next;
            }

            return linkedList;

        }

        public Node GetHead()
        {
            return this.head;
        }

        public Node GetTail()
        {
            return this.tail;
        }

        public int GetLenth()
        {
            return this.length;
        }
    }

    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
