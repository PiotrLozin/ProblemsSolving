// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        IList<IList<int>> possibleResults = new List<IList<int>>();
        IList<int> newResult1 = new List<int> { 1,1,6 };
        IList<int> newResult2 = new List<int> { 1,2,5 };
        IList<int> newResult3 = new List<int> { 1,7 };
        IList<int> newResult4 = new List<int> { 2,6 };
        possibleResults.Add(newResult1);
        possibleResults.Add(newResult2);
        possibleResults.Add(newResult3);
        possibleResults.Add(newResult4);


        Assert.Equal(possibleResults, CombinationSumII.CombinationSum2(candidates, 8));
    }
}