using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class CombinationSumII
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<int> smallerCandidates = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();

            foreach (int candidate in candidates)
            {
                if (candidate <= target)
                {
                    smallerCandidates.Add(candidate);
                }
            }

            smallerCandidates.Sort();

            for (int i = smallerCandidates.Count - 1; i >= 0; i--)
            {
                IList<IList<int>> possibleResults = new List<IList<int>>();

                int j = 0;
                IList<int> newResult = new List<int> { smallerCandidates[i] };
                possibleResults.Add(newResult);

                while (smallerCandidates[i] + smallerCandidates[j] <= target)
                {
                    if (j >= i)
                    {
                        break;
                    }

                    foreach (IList<int> possibleResult in possibleResults.ToList())
                    {
                        newResult = new List<int>(possibleResult);
                        newResult.Add(smallerCandidates[j]);

                        if (newResult.Sum(x => x) <= target && !possibleResults.Any(x => x.SequenceEqual(newResult)))
                        {
                            possibleResults.Add(newResult);
                        }
                    }

                    j++;
                }

                foreach (IList<int> possibleResult in possibleResults)
                {
                    if (possibleResult.Sum(x => x) == target)
                    {
                        if (!result.Any(existing => existing.SequenceEqual(possibleResult)))
                        {
                            result.Add(possibleResult);
                        }
                    }
                }
            }

            return result;

        }
    }
}
