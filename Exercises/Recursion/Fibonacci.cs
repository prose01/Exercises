using System.Collections.Generic;

namespace Exercises
{
    public class Fibonacci
    {
        // Given a number N return the index value of the Fibonacci sequence, where the sequence is:

        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 ...
        // the pattern of the sequence is that each value is the sum of the 2 previous values, that means that for N=5 → 2+3

        //For example: fibonacciRecursive(6) should return 8

        //O(n) Pretty good but not clear
        public int FibonacciIteratively(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int result = 1;
            int lastNumber = 0;
            int temp;

            for (int i = 1; i < n; i++)
            {
                temp = result;
                result += lastNumber;
                lastNumber = temp;
            }

            return result;
        }

        //O(n) Pretty good
        // Teacher's version.
        public int FibonacciIteratively2(int n)
        {
            List<int> result = new List<int>() { 0, 1 };


            for (int i = 2; i < n + 1; i++)
            {
                result.Add(result[i -2] + result[i-1]);
            }

            return result[n];
        }

        //O(n) ok, but not easy
        public int FibonacciRecursivelyEfficient(int n, int val, int prev)
        {
            if (n == 0)
            {
                return prev;
            }

            if (n == 1)
            {
                return val;
            }

            return this.FibonacciRecursivelyEfficient(n - 1, val + prev, val);
        }

        //O(2^n) very bad
        public int FibonacciRecursively(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return this.FibonacciRecursively(n - 1) + this.FibonacciRecursively(n - 2);
        }
    }
}
