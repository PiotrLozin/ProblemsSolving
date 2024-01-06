// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4 };
        int[] expectedInts = { 24, 12, 8, 6 };
        Assert.Equal(expectedInts, ProductOfArrayExceptSelf.productOfArrayExceptSelf(ints));

        int[] ints1 = { -1, 1, 0, -3, 3 };
        int[] expectedInts1 = { 0, 0, 9, 0, 0 };
        Assert.Equal(expectedInts1, ProductOfArrayExceptSelf.productOfArrayExceptSelf(ints1));
    }
}