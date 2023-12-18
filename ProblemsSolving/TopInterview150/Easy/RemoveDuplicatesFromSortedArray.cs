using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int removeDuplicates(ref int[] nums)
        {
            int counter = 1;
            int previouse = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != previouse)
                {
                    nums[counter] = nums[i];
                    counter++;
                }
                previouse = nums[i];
            }
            return counter;
        }
    }

    //public static void Main(string[] args)
    //{
    //    int[] nums = { 1, 1, 2 }; // Input array
    //    int[] expectedNums = { 1, 2 }; // The expected answer with correct length

    //    int k = RemoveDuplicatesFromSortedArray.removeDuplicates(ref nums); // Calls your implementation

    //    Assert.True(k == expectedNums.Length);
    //    for (int i = 0; i < k; i++)
    //    {
    //        Assert.Equal(nums[i], expectedNums[i]);
    //    }
    //}
}
