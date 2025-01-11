using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class MaximumDIstanceInArrays
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            List<KeyValuePair<int, int>> max = new List<KeyValuePair<int, int>>();
            List<KeyValuePair<int, int>> min = new List<KeyValuePair<int, int>>();


            for (int i = 0; i < arrays.Count; i++)
            {
                int actualMax = arrays[i].Max();
                int actualMin = arrays[i].Min();

                if (max.Count == 0 || max.Count == 1) 
                {
                    max.Add(new KeyValuePair<int, int>(i, actualMax));
                    min.Add(new KeyValuePair<int, int>(i, actualMin));
                    continue;
                }

                if (max.FirstOrDefault().Value <= actualMax)
                {
                    max.Insert(0, new KeyValuePair<int, int>(i, actualMax));
                }

                if (min.FirstOrDefault().Value >= actualMin)
                {
                    min.Insert(0, new KeyValuePair<int, int>(i, actualMin));
                }
            }

            return CalculateDistance(max, min);
        }

        private int CalculateDistance(List<KeyValuePair<int, int>> max, List<KeyValuePair<int, int>> min)
        {
            int result = 0;

            foreach (KeyValuePair<int, int> kvp in max)
            {
                foreach (KeyValuePair<int, int> kvm in min)
                {
                    int actualResult = Math.Abs(kvp.Value - kvm.Value);
                    if (kvp.Key != kvm.Key && actualResult > result)
                    {
                        result = actualResult;
                    }
                }
            }

            return result;
        }
    }
}
