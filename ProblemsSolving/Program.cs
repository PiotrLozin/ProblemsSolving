// See https://aka.ms/new-console-template for more information
using ProblemsSolving;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = { 3, 2, 2, 3 };

        int val = 3;

        RemoveElement.removeElement(ref nums1, val);

        foreach (int element in nums1)
        {
            Console.WriteLine(element);
        }
    }
}