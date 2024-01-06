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
