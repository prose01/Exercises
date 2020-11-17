using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Stack_Using_Array
    {
        private readonly ArrayList stack;

        public Stack_Using_Array()
        {
            this.stack = new ArrayList { };
        }

        public string Peek()
        {
            return this.stack[this.stack.Count -1].ToString();
        }

        public void Push(int value)
        {
            this.stack.Add(value);
        }

        public int Pop()
        {
            this.stack.RemoveAt(this.stack.Count - 1);
            return this.stack.Count;
        }

        public bool IsEmpty()
        {
            return !(this.stack.Count > 0);
        }

        public List<int> PrintStack()
        {
            return stack.Cast<int>().ToList();
        }
    }
}
