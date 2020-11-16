using System.Collections.Generic;

namespace Exercises
{
    public class DoublyLinkedList
    {
        private DoubleNode head;
        private DoubleNode tail;
        private int length;

        public DoublyLinkedList(int value)
        {
            this.head = new DoubleNode(value);
            this.tail = this.head;
            this.length++;
        }

        public void Append(int value)
        {
            var newNode = new DoubleNode(value);
            newNode.Previous = this.tail;
            this.tail.Next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            var newNode = new DoubleNode(value);

            this.head.Previous = newNode;
            newNode.Next = this.head;
            this.head = newNode;
            this.length++;
        }

        public void Insert(int index, int value)
        {
            if(this.length == 1)
            {
                this.Prepend(value);
                return;
            }

            if (index >= this.length)
            {
                this.Append(value);
                return;
            }

            var newNode = new DoubleNode(value);

            var leader = this.TraverseToIndex(index - 1);

            newNode.Previous = leader;
            newNode.Next = leader.Next;
            leader.Next = newNode;
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
                this.head.Previous = null;
                return; // let's just get out of here.
            }

            var removedNode = this.TraverseToIndex(index);
            removedNode.Previous.Next = removedNode.Next;
            removedNode.Next.Previous = removedNode.Previous;
            this.length--;
        }


        /// <summary>Traverses to index. Where we slice the linkedList.</summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        private DoubleNode TraverseToIndex(int index)
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

        public List<int> PrintDoublyLinkedList()
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

        public DoubleNode GetHead()
        {
            return this.head;
        }

        public DoubleNode GetTail()
        {
            return this.tail;
        }

        public int GetLenth()
        {
            return this.length;
        }
    }

    public class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Previous { get; set; }

        public DoubleNode(int value)
        {
            this.Value = value;
            this.Next = null;
            this.Previous = null;
        }
    }
}
