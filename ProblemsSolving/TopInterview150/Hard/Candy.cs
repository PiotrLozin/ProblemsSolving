using ProblemsSolving.TopInterview150.Medium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Hard
{
    public class Candy
    {
        public int candy(int[] ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];
            Array.Fill(candies, 1);

            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            return candies.Sum();
        }
    }

    //public static void Main(string[] args)
    //{
    //    int[] gas = { 1, 2, 3, 4, 5 };
    //    int[] cost = { 3, 4, 5, 1, 2 };
    //    Assert.Equal(3, GasStation.gasStation(gas, cost));

    //    int[] gas1 = { 2, 3, 4 };
    //    int[] cost1 = { 3, 4, 3 };
    //    Assert.Equal(-1, GasStation.gasStation(gas1, cost1));
    //}
}

