// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using NUnit;

public class Program
{
    public static MaximumDIstanceInArrays MaximumDistanceInArrays = new MaximumDIstanceInArrays();

    public Program(MaximumDIstanceInArrays maximumDIstanceInArrays)
    {
        MaximumDistanceInArrays = maximumDIstanceInArrays;
    }

    public static void Main(string[] args)
    {
        NeighboringBitwiseXorTests neighboringBitwiseXorTests = new NeighboringBitwiseXorTests();
        neighboringBitwiseXorTests.FirstTest();
    }
}