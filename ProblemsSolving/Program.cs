// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] words = { "aba", "bcb", "ece", "aa", "e" };
        int[][] queries = { new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 1 } };

        Assert.Equal(new int[] { 2, 3, 0}, VowelStringsProblem.VowelStrings(words, queries));
    }
}