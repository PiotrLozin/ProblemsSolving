using System.Collections.Generic;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class MajorityElement
    {
        public static int majorityElement(ref int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int x in nums) 
            {
                //Create a dictionary with each unique element and the number of times it appears in the list
                if (!map.ContainsKey(x))
                {
                    map.Add(x, 1);
                }
                else
                {
                    map[x]++;
                }
            }

            //Get key with max value from dictionary
            int maxKey = map.MaxBy(kvp => kvp.Value).Key;

            return maxKey;
        }
    }

    //public static void Main(string[] args)
    //{
    //    int[] nums = { 2, 2, 1, 1, 1, 2, 2 }; // Input array

        //int k = MajorityElement.majorityElement(ref nums); // Calls your implementation

        //Assert.True(k == 2);
    //}
}
