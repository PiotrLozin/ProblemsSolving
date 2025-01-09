using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class CountingWordsWithGivenPrefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;

            foreach (string word in words)
            {
                if (word.StartsWith(pref))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
