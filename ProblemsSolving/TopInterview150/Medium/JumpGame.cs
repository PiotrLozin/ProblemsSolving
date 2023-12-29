using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class JumpGame
    {
        public bool jumpGame(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if ((nums[j] + j > i) || (nums[j] + j == nums.Length - 1))
                            break;

                        if (j == 0)
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
