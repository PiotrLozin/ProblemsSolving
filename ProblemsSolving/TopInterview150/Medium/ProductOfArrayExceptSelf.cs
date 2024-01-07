using ProblemsSolving.TopInterview150.Medium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class ProductOfArrayExceptSelf
    {
        public static int[] productOfArrayExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] productCalculated = new int[n];

            // Initialize the product of the multiplication on the left side
            int leftProduct = 1;
            for(int i = 0; i < n; i++)
            {
                productCalculated[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // Initialize the product of the multiplication on the right side
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                productCalculated[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return productCalculated;
        }
    }
}

//public static void Main(string[] args)
//{
//    int[] ints = { 1, 2, 3, 4 };
//    int[] expectedInts = { 24, 12, 8, 6 };
//    Assert.Equal(expectedInts, ProductOfArrayExceptSelf.productOfArrayExceptSelf(ints));

//    int[] ints1 = { -1, 1, 0, -3, 3 };
//    int[] expectedInts1 = { 0, 0, 9, 0, 0 };
//    Assert.Equal(expectedInts1, ProductOfArrayExceptSelf.productOfArrayExceptSelf(ints1));
//}
