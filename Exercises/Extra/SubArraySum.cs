using System;

namespace Exercises
{
    public class SubArraySum
    {
        public int MaxSubArraySum(int[] arr, int num) // 0(n^2) My Naive approach
        {
            if(arr.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for(var i = 0; i < arr.Length; i++)
            {
                var subSum = arr[i];

                for(var j = 1; j < num; j++)
                {
                    if (i + num < arr.Length)
                    {
                        subSum += arr[i + j];
                    }
                }

                sum = Math.Max(sum, subSum);
                //if (sum < subSum)
                //{
                //    sum = subSum;
                //}
            }

            return sum;
        }

        public int MaxSubArraySum2(int[] arr, int num) // 0(n^2) Teachers Naive approach. 
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (var i = 0; i < arr.Length - num + 1; i++) // Bedre - Dette sikre at vi ikke kommer forbi arr.Lenth.
            {
                var subSum = 0;

                for (var j = 0; j < num; j++)
                {
                    subSum += arr[i + j];
                }

                if (sum < subSum)
                {
                    sum = subSum;
                }
            }

            return sum;
        }

        public int MaxSubArraySumSlidingWindow(int[] arr, int num) // 0(n) Teachers. 
        {
            int maxSum = 0;
            int subSum = 0;

            if (arr.Length < num)
            {
                return 0;
            }

            for (var i = 0; i < num; i++)   // Just add up the first num of digits to create your window.
            {
                maxSum += arr[i];
            }

            subSum = maxSum;

            for (var i = num; i < arr.Length; i++)      // Now move the window by subtracting and adding.
            {
                subSum = subSum - arr[i - num] + arr[i]; // Subtract the first/left (arr[i - num]) and add the last/right (arr[i]) of your window.

                maxSum = Math.Max(maxSum, subSum); // Check which is bigger and keep that.
            }
            
            return maxSum;
        }
    }
}
