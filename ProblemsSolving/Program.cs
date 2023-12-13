// See https://aka.ms/new-console-template for more information
using ProblemsSolving;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };

        int m = 3;
        int n = 3;

        MergeSortedArray.Merge(ref nums1, m, nums2, n);

        foreach (int element in nums1)
        {
            Console.WriteLine(element);
        }
    }
}