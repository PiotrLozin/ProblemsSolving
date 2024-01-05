// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        Assert.Equal(3, RomanToInteger.romanToInteger("III"));
        Assert.Equal(58, RomanToInteger.romanToInteger("LVIII"));
        Assert.Equal(1994, RomanToInteger.romanToInteger("MCMXCIV"));
    }
}