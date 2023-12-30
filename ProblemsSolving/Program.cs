// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        Assert.True(randomizedSet.Insert(1));
        Assert.True(randomizedSet.Insert(2));
        Assert.True(!randomizedSet.Insert(2));
        Assert.True(randomizedSet.Remove(2));
        Assert.Equal(1, randomizedSet.GetRandom());
    }
}