using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class ShiftingLetters
    {
        public static string ShiftingLetterss(string s, int[][] shifts)
        {
            var result = s.ToCharArray();
            var shiftsArr = new int[s.Length];

            for (int i = 0; i < shifts.Length; i++)
            {
                var start = shifts[i][0];
                var end = shifts[i][1];
                var direction = shifts[i][2] == 0 ? -1 : 1;

                shiftsArr[start] += direction;

                if (end + 1 < s.Length)
                {
                    shiftsArr[end + 1] -= direction;
                }
            }

            var shift = 0;
            for (int i = 0; i < s.Length; i++)
            {
                shift += shiftsArr[i];
                if (shift != 0)
                {
                    var newCharValue = (result[i] - 'a' + shift) % 26;
                    if (newCharValue < 0)
                    {
                        newCharValue += 26;
                    }

                    result[i] = (char)(newCharValue + 'a');
                }
            }

            return new String(result);
        }
    }
}
