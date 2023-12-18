namespace ProblemsSolving.TopInterview150.Easy
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
    //    int[] nums1 = { 3, 2, 2, 3 };

    //    int val = 3;

    //    RemoveElement.removeElement(ref nums1, val);

    //    foreach (int element in nums1)
    //    {
    //        Console.WriteLine(element);
    //    }
    //}
}
