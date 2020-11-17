using System;
using System.Collections.Generic;

namespace Exercises.Stack_and_Queue
{
    // This code is taken from https://github.com/anirban-s/data-structures-and-algorithms/blob/master/4.%20DS%20-%20Stack%20and%20Queue/Queue_Using_Stack.cs !!!!!!

    public class Queue_Using_Stack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> auxiliaryStack = new Stack<int>();

        public int peek()
        {
            fillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Peek();
            fillStackWithAuxiliaryStack();
            return value;
        }

        public void enqueue(int value)
        {
            this.stack.Push(value);
        }

        public int dequeue()
        {
            fillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Pop();
            fillStackWithAuxiliaryStack();
            return value;
        }

        public void printQueue()
        {
            if (stack.Count == 0)
            {
                return;
            }

            fillAuxiliaryStackWithStack();
            foreach (var i in auxiliaryStack)
            {
                Console.Write("-->" + i);
            }
            Console.WriteLine();
            fillStackWithAuxiliaryStack();
        }

        private void fillAuxiliaryStackWithStack()
        {
            while (stack.Count > 0)
            { //Making the "auxiliaryStack" stack as queue of "Stack"
                auxiliaryStack.Push(stack.Pop());
            }
        }

        private void fillStackWithAuxiliaryStack()
        {
            while (auxiliaryStack.Count > 0)
            { //Return stack to the original state
                stack.Push(auxiliaryStack.Pop());
            }
        }

    }
}
