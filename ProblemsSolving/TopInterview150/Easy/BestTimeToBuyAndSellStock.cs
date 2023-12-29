using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class BestTimeToBuyAndSellStockII
    {
        public static int bestTimeToBuyAndSellStockII(ref int[] prices)
        {
            var totalProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    totalProfit += prices[i] - prices[i - 1];
                }
            }

            return totalProfit;
        }
    }
}
