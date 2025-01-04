using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class PalindromicSubsequences
    {
        public static int CountPalindromicSubsequence(string s)
        {
            int countPalindicSubsequence = 0;
            Dictionary<char, int> charsMap = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charsMap.ContainsKey(c))
                {
                    charsMap[c]++;
                }
                else
                {
                    charsMap.Add(c, 1);
                }
            }

            foreach (var map in charsMap)
            {
                if (map.Value > 2)
                {
                    countPalindicSubsequence++;
                }

                if (map.Value > 1)
                {
                    int leftIndex = s.IndexOf(map.Key);
                    int rightIndex = s.LastIndexOf(map.Key);
                    List<int> list = new List<int>();

                    for (int i = leftIndex + 1; i < rightIndex; i++) 
                    {
                        if (s[i] != map.Key && !list.Contains(s[i]))
                        {
                            countPalindicSubsequence++;
                            list.Add(s[i]);
                        }
                    }
                }
            }

            return countPalindicSubsequence;
        }
    }
}
