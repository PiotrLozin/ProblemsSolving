using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class MinimumLengthOfStringAfterOperations
    {
        public int MinimumLength(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            int result = 0;
            foreach (KeyValuePair<char, int> pair in map)
            {
                if (pair.Value%2 == 1)
                {
                    result++;
                }
                else
                {
                    result+= 2;
                }
            }

            return result;
        }
    }
}
