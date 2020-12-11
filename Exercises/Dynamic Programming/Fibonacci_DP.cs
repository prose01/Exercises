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




        // Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.

        //Example 1:
        //Input: nums = [1,2,3,1]
        //Output: 4
        //Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
        //             Total amount you can rob = 1 + 3 = 4.


        //Example 2:
        //Input: nums = [2,7,9,3,1]
        //Output: 12
        //Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
        //             Total amount you can rob = 2 + 9 + 1 = 12.


        List<int> sums = new List<int>();

        public int HouseRobber(int[] nums)      // Din løsning er ikke god! For det første bruger du sort og for det andet er sums udenfor metoden.
        {
            for(var i = 0; i < nums.Length; i++)
            {
                if (sums.Count < 2)
                {
                    sums.Add(nums[i]);
                }
                else
                {
                    sums.Add(sums[i - 2] + nums[i]);
                }
            }

            var bubbleSort = new BubbleSort();
            var result = bubbleSort.SortDesc(sums.ToArray());

            return result[0];
        }

        public int Rob(int[] nums)          // Bedre løsning uden recursion og for meget memory brug.
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int v2 = 0; // value 2 back
            int v1 = 0; // value 1 back

            for (int i = 0; i < nums.Length; i++)
            {
                int v = v1 > nums[i] + v2 ? v1 : nums[i] + v2; // current value
                v2 = v1;
                v1 = v;
            }

            return v1;
        }
    }
}
