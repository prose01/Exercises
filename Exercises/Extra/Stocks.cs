namespace Exercises
{
    public class Stocks
    {
        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        // Say you have an array for which the ith element is the price of a given stock on day i.

        //If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

        //Note that you cannot sell a stock before you buy one.


        //Example 1:
        //Input: [7,1,5,3,6,4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //             Not 7-1 = 6, as selling price needs to be larger than buying price.

        //Example 2:
        //Input: [7,6,4,3,1]
        //Output: 0
        //Explanation: In this case, no transaction is done, i.e.max profit = 0.


        // Brute Force - Not good with loop in loop.
        public int MaxProfit(int[] prices)
        {
            int maxprofit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];

                    if (profit > maxprofit)
                        maxprofit = profit;
                }
            }

            return maxprofit;
        }

        // One pass and use of a little memory.
        public int MaxProfit2(int[] prices)
        {
            int highest = 0;
            int lowest = int.MaxValue;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] < lowest)
                {
                    lowest = prices[i];
                }
                else if (prices[i] - lowest > highest)
                {
                    highest = prices[i] - lowest;
                }
            }

            return highest;
        }
    }
}
