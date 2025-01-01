using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class MaximumScoreAfterSplittingAString
    {
        public int MaxScore(string s)
        {
            int MaxScore = 0;

            for (int i = 1; i < s.Length; i++)
            {
                string first = s[..i];
                string second = s[i..];

                int countOfZeros = first.Count(x => x == '0');
                int countOfOnes = second.Count(x => x == '1');

                var sum = countOfZeros + countOfOnes;
                if (sum > MaxScore)
                {
                    MaxScore = sum;
                }
            }

            return MaxScore;
        }
    }
}
