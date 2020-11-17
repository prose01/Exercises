using System.Collections.Generic;

namespace Exercises
{
    public class Queue_Using_Linkedlist
    {
        private QueueNode first;
        private QueueNode last;
        private int length;

        public Queue_Using_Linkedlist()
        {
            this.first = null;
            this.last = null;
            this.length = 0;
        }

        public int Peek()
        {
            if (this.length == 0)
            {
                return 0;
            }

            return this.first.Value;
        }

        public void Enqueue(int value)
        {
            var newNode = new QueueNode(value);

            if(this.length == 0)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.Next = newNode;
                this.last = newNode;
            }

            this.length++;
        }

        public int Dequeue()
        {
            this.first = this.first.Next;
            this.length--;
            return this.length;
        }

        public bool IsEmpty()
        {
            return this.length == 0 ? true : false;
        }

        public List<int> PrintQueue()
        {
            var queque = new List<int>();

            var currentNode = this.first;

            while(currentNode != null)
            {
                queque.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return queque;
        }
    }

    public class QueueNode
    {
        public int Value { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
