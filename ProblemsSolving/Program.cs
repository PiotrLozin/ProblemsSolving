﻿// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        string s = "bbcbaba";

        Assert.Equal(4, PalindromicSubsequences.CountPalindromicSubsequence(s));
    }
}