using ProblemsSolving.TopInterview150.Medium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class GasStation
    {
        public static int gasStation(int[] gas, int[] cost)
        {
            int sum = gas[^1] - cost[^1];
            int maxIndex = gas.Length - 1;
            int maxSum = sum;

            for (int i = gas.Length - 2; i >= 0; i--)
            {
                sum += gas[i] - cost[i];
                if (sum > maxSum)
                {
                    maxIndex = i;
                    maxSum = sum;
                }
            }

            if (sum < 0) return -1;
            return maxIndex;

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

