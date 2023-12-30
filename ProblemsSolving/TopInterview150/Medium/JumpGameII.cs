using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class HIndex
    {
        public int hIndex(int[] citations)
        {

            Array.Sort(citations);
            int possibleH = 0;

            for (int i = citations.Length - 1; i > 0; i--)
            {
                possibleH = citations[i];
                while (possibleH >= citations[i - 1])
                {
                    if (possibleH <= citations.Length - i)
                        return possibleH;

                    possibleH--;
                }
            }

            possibleH = citations[citations.Length - 1];
            while (possibleH > 0)
            {
                if (possibleH <= citations.Length)
                    return possibleH;

                possibleH--;
            }

            return 0;
        }
    }
}
