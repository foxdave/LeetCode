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
        /// DP dp0表示手里没有股票的最大利润 dp1表示手里有股票的最大利润
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
        /// 参照题122，从dp0空仓和dp1持有股票两种状态转化到四种状态
        /// 第一次买b1，第一次卖s1，第二次买b2，第二次卖s2的最大利润
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit3(int[] prices)
        {
            int b1 = -prices[0], b2 = -prices[0], s1 = 0, s2 = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int currB1 = Math.Max(b1, -prices[i]);
                int currS1 = Math.Max(s1, b1 + prices[i]);
                int currB2 = Math.Max(b2, s1 - prices[i]);
                int currS2 = Math.Max(s2, b2 + prices[i]);
                b1 = currB1; b2 = currB2; s1 = currS1; s2 = currS2;
            }
            return s2;
        }
    }
}
