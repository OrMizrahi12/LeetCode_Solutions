using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class MaxProfitS
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int price = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (price > prices[i]) price = prices[i];
                if (prices[i] - price > maxProfit) maxProfit = prices[i] - price;
            }
            return maxProfit;
        }
    }
}
