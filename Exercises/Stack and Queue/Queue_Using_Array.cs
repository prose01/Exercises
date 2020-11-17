using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Queue_Using_Array
    {
        private readonly ArrayList queue;

        public Queue_Using_Array()
        {
            this.queue = new ArrayList { };
        }

        public string Peek()
        {
            return queue[0].ToString();
        }

        public void Enqueue(int value)
        {
            this.queue.Add(value);
        }

        public int Dequeue()
        {
            this.queue.RemoveAt(0);
            return queue.Count;
        }

        public bool IsEmpty()
        {
            return this.queue.Count > 0 ? false : true;
        }

        public List<int> PrintQueue()
        {
            return this.queue.Cast<int>().ToList();
        }
    }
}
