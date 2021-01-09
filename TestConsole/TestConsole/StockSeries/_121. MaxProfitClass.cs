using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.StockSeries
{
    public class MaxProfitClass
    {
        /// <summary>
        /// ID 121
        /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        //public int MaxProfit1(int[] prices)
        //{
        //    int maxProfit = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            int currProfit = prices[j] - prices[i];
        //            maxProfit = currProfit > maxProfit ? currProfit : maxProfit;
        //        }
        //    }
        //    return maxProfit;
        //}
        public int MaxProfit1(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    maxProfit = prices[i] - minPrice > maxProfit ? prices[i] - minPrice : maxProfit;
                }
            }
            return maxProfit;
        }

        /// <summary>
        /// ID 122
        /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/
        /// DP
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit2(int[] prices)
        {
            int dp0 = 0;
            int dp1 = -prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                int currDp0 = Math.Max(dp0, dp1 + prices[i]);
                int currDp1 = Math.Max(dp1, dp0 - prices[i]);
                dp0 = currDp0;
                dp1 = currDp1;
            }
            return dp0;
        }

        /// <summary>
        /// ID 123
        /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-iii/
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit3(int[] prices)
        {
            return 0;
        }
    }
}
