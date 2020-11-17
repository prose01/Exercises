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
            this.tail.Next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            var newNode = new Node(value);
            newNode.Next = this.head;
            this.head = newNode;
            this.length++;
        }

        public void Reverse()
        {
            if(this.length == 1)
            {
                return; // There is nothing to reverse so let's just get out of here.
            }

            // My version
            //int counter = 0;

            //var currentNode = this.head;

            //var newNode = new SinglyLinkedList(this.head.Value);
            //newNode.tail = null;

            //while (counter != this.length - 1)
            //{
            //    newNode.Prepend(currentNode.Next.Value);
            //    currentNode = currentNode.Next;
            //    counter++;
            //}

            //this.head = newNode.head;
            //this.tail = newNode.tail;
            //this.length = newNode.length;

            // Udemy version
            Node first = head;
            tail = head;
            Node second = first.Next;
            for (int i = 0; i < length - 1; i++)
            {
                Node temp = second.Next;
                second.Next = first;
                first = second;
                second = temp;
            }
            head.Next = null;
            head = first;
        }

        public void Insert(int index, int value)
        {
            if (index == 1)
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

            newNode.Next = leader.Next; // Insert everythign after the slice into the new node.

            leader.Next = newNode; // Simply add the new node where we sliced the old list.

            this.length++;
        }

        public void Remove(int index)
        {
            if (index > this.length)
            {
                return; // let's just get out of here.
            }

            if (index == 0)
            {
                this.head = this.head.Next;
                return; // let's just get out of here.
            }

            var leader = this.TraverseToIndex(index - 1);

            var removedNode = leader.Next;

            leader.Next = removedNode.Next;
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
                currentNode = currentNode.Next;
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
                linkedList.Add(currentNode.Value);
                currentNode = currentNode.Next;
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
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
