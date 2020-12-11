using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Fibonacci_DP
    {
        // Given a number N return the index value of the Fibonacci sequence, where the sequence is:

        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 ...
        // the pattern of the sequence is that each value is the sum of the 2 previous values, that means that for N=5 → 2+3

        //For example: fibonacciRecursive(6) should return 8

        //public Func<int, int> Fibonacci()
        //{
        //    Dictionary<int, int> memory = new Dictionary<int, int>();

        //    Func<int, int> FibonacciRecursively = delegate (int n)
        //    {
        //        if (n < 2)
        //        {
        //            return n;
        //        }

        //        if (memory.ContainsKey(n))
        //        {
        //            return memory[n];
        //        }

        //        memory.Add(n, this.FibonacciRecursively(n - 1) + this.FibonacciRecursively(n - 2));

        //        return memory[n];
        //    };

        //    return FibonacciRecursively;
        //}

        private Dictionary<int, int> cache = new Dictionary<int, int>();

        public int FibonacciMaster(int n)
        {
            if (cache.ContainsKey(n))
            {
                return cache[n];
            }

            if (n < 2)
            {
                return n;
            }

            cache.Add(n, FibonacciMaster(n - 1) + FibonacciMaster(n - 2));

            return cache[n];
        }

        //Builds up a list from buttom up instead of doing recursion. It keeps adding to the memory list as it goes along. 
        public int FibonacciButtomUp(int n)
        {
            List<int> memory = new List<int>() { 0, 1 };

            for (var i = 2; i <= n; i++) // Remember only to run up until current n number. 
            {
                memory.Add(memory[i - 1] + memory[i - 2]); // Take the two preceeding numbers and add them together.
            }

            return memory[memory.Count - 1]; // return the last added number. 
        }
    }
}
