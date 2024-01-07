// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] gas = { 1, 2, 3, 4, 5 };
        int[] cost = { 3, 4, 5, 1, 2 };
        Assert.Equal(3, GasStation.gasStation(gas, cost));

        int[] gas1 = { 2,3, 4 };
        int[] cost1 = { 3, 4, 3 };
        Assert.Equal(-1, GasStation.gasStation(gas1, cost1));
    }
}