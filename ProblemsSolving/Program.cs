// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] height = { 4, 2, 3 };
        Assert.Equal(1,TrappingRainWatter.trappingRainWatter(height));
    }
}