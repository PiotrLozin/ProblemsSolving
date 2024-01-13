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
        public static int candy(int[] ratings)
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
    //    int[] ratings = { 1, 2, 87, 87, 87, 2, 1 };
    //    Assert.Equal(13, Candy.candy(ratings));
    //}
}

