using System.Collections.Generic;

namespace Exercises
{
    public class HouseRobber
    {
        // https://leetcode.com/problems/house-robber/
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

        public int MyRobber(int[] nums)      // Din løsning er ikke god! For det første bruger du sort og for det andet er sums udenfor metoden.
        {
            for (var i = 0; i < nums.Length; i++)
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
