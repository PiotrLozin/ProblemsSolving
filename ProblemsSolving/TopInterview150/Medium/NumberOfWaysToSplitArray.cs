using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class NumberOfWaysToSplitArray
    {
        public static int WaysToSplitArray(int[] nums)
        {
            int waysToSplitArray = 0;
            long rightSum = 0;
            long leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }

            for (int i = 0; i < nums.Length - 2; i++)
            {
                leftSum += nums[i];
                if (leftSum >= rightSum - leftSum)
                {
                    waysToSplitArray++;
                }
            }

            return waysToSplitArray;
        }
    }
}
