// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] ratings = { 1, 2, 87, 87, 87, 2, 1 };
        Assert.Equal(13, Candy.candy(ratings));
    }
}