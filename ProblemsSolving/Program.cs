// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

internal class Program
{
    public static void Main(string[] args)
    {
        Assert.Equal("III", IntegerToRoman.integerToRoman(3));
        Assert.Equal("LVIII", IntegerToRoman.integerToRoman(58));
        Assert.Equal("MCMXCIV", IntegerToRoman.integerToRoman(1994));
    }
}