using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class StringMatchingInArray
    {
        public static IList<string> StringMatching(string[] words)
        {
            IList<string> result = new List<string>();
            foreach (string word in words)
            {
                foreach (string word2 in words)
                {
                    if (word2.Contains(word) && !word.Equals(word2))
                    {
                        result.Add(word);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
