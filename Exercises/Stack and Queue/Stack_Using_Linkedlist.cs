using System.Collections.Generic;

namespace Exercises
{
    public class Stack_Using_Linkedlist
    {
        private StackNode top;
        private StackNode buttom;
        private int length;

        public Stack_Using_Linkedlist()
        {
            this.top = null;
            this.buttom = null;
            this.length = 0;
        }

        public int Peek()
        {
            return this.top.Value;
        }

        public void Push(int value)
        {
            var newStackNode = new StackNode(value);
            newStackNode.Next = this.top;
            this.top = newStackNode;

            if (this.buttom == null)
            {
                this.buttom = newStackNode;
            }

            this.length++;
        }

        public int Pop()
        {
            if(this.top == null)
            {
                return 0; // There is nothing to Pop so let's just get out of here.
            }

            this.top = this.top.Next;
            this.length--;
            return this.length;
        }

        public bool IsEmpty()
        {
            return this.top == null;
        }

        public List<int> PrintStack()
        {
            var stackValues = new List<int>();

            if (this.top == null)
            {
                return stackValues;
            }

            var currentNode = this.top;

            while (currentNode != null)
            {
                stackValues.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return stackValues;
        }
    }

    public class StackNode
    {
        public int Value { get; set; }
        public StackNode Next { get; set; }

        public StackNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
