using ProblemsSolving.TopInterview150.Medium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Hard
{
    public class TrappingRainWatter
    {
        public static int checkNextClosure(int[] height, ref int actual)
        {
            int counter = 0;
            while (actual > 0)
            {
                foreach (int x in height)
                {
                    if (x >= actual)
                    {
                        return counter;
                    }

                    counter++;
                }

                actual--;
                counter = 0;
            }
            return counter;
        }

        public static int checkAmountOfWater(int[] height, int actual)
        {
            int sum = 0;

            foreach (int x in height)
            {
                sum += actual - x;
            }

            return sum;
        }

        public static int trappingRainWatter(int[] height)
        {
            int sumOfRainWater = 0;

            for (int i = 0; i < height.Length - 1; i++)
            {
                if (height[i] == 0)
                    continue;

                int j = i + 1;
                int waterSteps = checkNextClosure(height[j..], ref height[i]);

                if (waterSteps > 0)
                {
                    sumOfRainWater += checkAmountOfWater(height[j..(j + waterSteps)], height[i]);
                    i += waterSteps - 1;
                }
            }

            return sumOfRainWater;
        }
    }

        
}

//public static void Main(string[] args)
//{
//    int[] ratings = { 1, 2, 87, 87, 87, 2, 1 };
//    Assert.Equal(13, Candy.candy(ratings));
//}

