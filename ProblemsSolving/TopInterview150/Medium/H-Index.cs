using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class JumpGameII
    {
        public int jumpGameII(int[] nums)
        {
            int counter = 1;
            int actualBestElement = 0;
            int i = 0;

            if (nums.Length == 1)
                return 0;

            while (i < nums.Length)
            {
                actualBestElement = 0;
                for (int j = i + 1; j <= (i + nums[i]); j++)
                {
                    if (j == nums.Length - 1)
                        return counter;

                    if (j + nums[j] > nums[actualBestElement] + actualBestElement)
                        actualBestElement = j;
                }

                if (actualBestElement == 0)
                    return 0;

                i = actualBestElement;
                counter++;
            }

            return 0;
        }
    }
}
