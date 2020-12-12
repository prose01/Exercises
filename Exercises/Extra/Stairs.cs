using System.Collections.Generic;

namespace Exercises
{
    public class Stairs
    {
        // https://leetcode.com/problems/climbing-stairs/
        // You are climbing a staircase. It takes n steps to reach the top.
        // Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

        //Example 1:
        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps

        //Example 2:
        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step


        // Brute Force with recursion - Time complexity : O(2^n) - Space complexity : O(n)
        public int ClimbStairs(int n)
        {
            return Climb_Stairs(0, n);
        }

        private int Climb_Stairs(int current, int n)
        {
            if (current > n)
            {
                return 0;
            }

            if (current == n)
            {
                return 1;
            }

            return Climb_Stairs(current + 1, n) + Climb_Stairs(current + 2, n);
        }

        // Recursion with Memoization.
        // In the previous approach we are redundantly calculating the result for every step. Instead, we can store the result at each step in memo Dictionary and directly returning the result from the memo Dictionary whenever that function is called again.
        // In this way we are pruning recursion tree with the help of memo Dictionary and reducing the size of recursion tree upto n.
        // Very simlar to FibonacciMaster in Fibonacci_DP!

        Dictionary<int, int> d = new Dictionary<int, int>();

        public int ClimbStairsMemoization(int n)
        {
            if (n < 3) return n;

            if (d.ContainsKey(n)) return d[n];

            d[n] = ClimbStairsMemoization(n - 1) + ClimbStairsMemoization(n - 2);

            return d[n];
        }

        // Using Fibonacci Number
        public int ClimbStairsFibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int first = 1;
            int second = 2;

            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }

            return second;
        }
    }
}
