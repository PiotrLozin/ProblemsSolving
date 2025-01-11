// See https://aka.ms/new-console-template for more information
using ProblemsSolving.TopInterview150.Easy;
using ProblemsSolving.TopInterview150.Hard;
using ProblemsSolving.TopInterview150.Medium;
using Xunit;

public class Program
{
    public static MaximumDIstanceInArrays MaximumDistanceInArrays = new MaximumDIstanceInArrays();

    public Program(MaximumDIstanceInArrays maximumDIstanceInArrays)
    {
        MaximumDistanceInArrays = maximumDIstanceInArrays;
    }

    public static void Main(string[] args)
    {
        int result = 4;
        
        IList<IList<int>> arrays = new List<IList<int>>();
        IList<int> newResult1 = new List<int> { 1,2,3 };
        IList<int> newResult2 = new List<int> { 4,5 };
        IList<int> newResult3 = new List<int> { 1,2,3 };
        arrays.Add(newResult1);
        arrays.Add(newResult2);
        arrays.Add(newResult3);


        Assert.Equal(result, MaximumDistanceInArrays.MaxDistance(arrays));
    }
}