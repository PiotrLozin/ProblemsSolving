using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class MinimumNumberOfOperationsTOMoveAllBallsToEachBox
    {
        public int[] MinOperations(string boxes)
        {
            int[] result = new int[boxes.Length];
            char[] chars = boxes.ToCharArray();

            for (int i = 0; i < chars.Length; i++) 
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == '1')
                    {
                        result[i] += Math.Abs(j - i);
                    }
                }
            }

            return result;
        }
    }
}
