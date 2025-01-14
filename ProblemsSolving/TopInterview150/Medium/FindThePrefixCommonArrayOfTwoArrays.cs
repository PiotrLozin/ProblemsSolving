using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class FindThePrefixCommonArrayOfTwoArrays
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();

            int[] result = new int[A.Length];
            result[0] = 0;

            for (int i = 0; i < A.Length; i++)
            {
                listA.Add(A[i]);
                listB.Add(B[i]);

                if (i != 0)
                {
                    result[i] = result[i - 1];
                }

                foreach (int common in listA)
                {
                    if (listB.Contains(common))
                    {
                        result[i]++;
                        listB.Remove(common);
                    }
                }
            }

            return result;
        }
    }
}
