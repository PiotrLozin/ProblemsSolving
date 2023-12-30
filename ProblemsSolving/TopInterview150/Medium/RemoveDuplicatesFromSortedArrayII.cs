using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public static int removeDuplicatesII(ref int[] nums)
        {
            int counter = 1;
            int previouse = nums[0];
            bool previouseWasUnique = true;

            for (int i = 1; i < nums.Length; i++)
            {
                if(previouseWasUnique && nums[i] == previouse)
                {
                    previouseWasUnique = false;
                    nums[counter] = nums[i];
                    counter++;
                }

                if (nums[i] != previouse)
                {
                    nums[counter] = nums[i];
                    previouseWasUnique = true;
                    counter++;
                }

                previouse = nums[i];
            }
            return counter;
        }
    }

    //public static void Main(string[] args)
    //{
    //    int[] nums = { 1, 1, 1, 2, 2, 3 }; // Input array
    //    int[] expectedNums = { 1, 1, 2, 2, 3 }; // The expected answer with correct length

    //    int k = RemoveDuplicatesFromSortedArray.removeDuplicates(ref nums); // Calls your implementation

    //    Assert.True(k == expectedNums.Length);
    //    for (int i = 0; i < k; i++)
    //    {
    //        Assert.Equal(nums[i], expectedNums[i]);
    //    }
    //}
}
