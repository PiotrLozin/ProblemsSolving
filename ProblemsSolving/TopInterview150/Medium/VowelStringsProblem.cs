using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class VowelStringsProblem
    {
        public static int[] VowelStrings(string[] words, int[][] queries)
        {
            char[] vowelLetters = { 'a', 'e', 'i', 'o', 'u' };
            int[] numeric = new int[words.Length];
            int[] vowelStrings = new int[queries.Length];
            int j = 0;
            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (vowelLetters.Any(x => x == words[i].First()))
                {
                    if (vowelLetters.Any(x => x == words[i].Last()))
                    {
                        sum++;
                    }
                }
                numeric[i] = sum;
            }

            foreach (var query in queries)
            {
                if (query[0] - 1 < 0) 
                {
                    vowelStrings[j] = numeric[query[1]];
                }
                else
                {
                    vowelStrings[j] = numeric[query[1]] - numeric[query[0] - 1];
                }
                j++;
            }

            return vowelStrings;
        }
    }
}
