namespace ProblemsSolving
{
    public class RemoveElement
    {
        public static int removeElement(ref int[] nums, int val)
        {
            //Remove all 'val' from array
            nums = nums.Where(x => x != val).ToArray();

            //Return number of elements in array after removing
            return nums.Length;
        }
    }

    //public static void Main(string[] args)
    //{
    //    int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    //    int[] nums2 = { 2, 5, 6 };

    //    int m = 3;
    //    int n = 3;

    //    MergeSortedArray.Merge(ref nums1, m, nums2, n);

    //    foreach (int element in nums1)
    //    {
    //        Console.WriteLine(element);
    //    }
    //}
}
