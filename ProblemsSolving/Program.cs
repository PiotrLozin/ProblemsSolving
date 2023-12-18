﻿// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 2 }; // Input array
        int[] expectedNums = { 1, 2 }; // The expected answer with correct length
        
        int k = RemoveDuplicatesFromSortedArray.removeDuplicates(ref nums); // Calls your implementation

        Assert.True(k == expectedNums.Length);
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(nums[i], expectedNums[i]);
        }
    }
}