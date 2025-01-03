// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 10, 4, -8, 7 };

        Assert.Equal(2, NumberOfWaysToSplitArray.WaysToSplitArray(nums));
    }
}