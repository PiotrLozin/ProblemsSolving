// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 }; // Input array

        int k = MajorityElement.majorityElement(ref nums); // Calls your implementation

        Assert.True(k == 2);
    }
}