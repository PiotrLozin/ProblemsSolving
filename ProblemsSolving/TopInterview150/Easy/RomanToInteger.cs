using Xunit;

namespace ProblemsSolving.TopInterview150.Easy
{
    public class RomanToInteger
    {
        public static int romanToInteger(string s)
        {
            var sum = 0;

            for(int i = 0; i < s.Length; i++) 
            {
                switch(s[i]) 
                {
                    case 'M':
                        sum += 1000;
                        break;

                    case 'D':
                        sum += 500;
                        break;

                    case 'C':
                        if (i < s.Length - 1) 
                        {
                            if (s[i + 1] == 'D' || s[i + 1] == 'M')
                            {
                                sum -= 100;
                                break;
                            }
                        }
                        sum += 100;
                        break;

                    case 'L':
                        sum += 50;
                        break;

                    case 'X':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'L' || s[i + 1] == 'C')
                            {
                                sum -= 10;
                                break;
                            }
                        }
                        sum += 10;
                        break;

                    case 'V':
                        sum += 5;
                        break;

                    case 'I':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'V' || s[i + 1] == 'X')
                            {
                                sum -= 1;
                                break;
                            }
                        }
                        sum += 1;
                        break;

                }
            }

            return sum;
        }
    }

    //public static void Main(string[] args)
    //{
    //    Assert.Equal(3, RomanToInteger.romanToInteger("III"));
    //    Assert.Equal(58, RomanToInteger.romanToInteger("LVIII"));
    //    Assert.Equal(1994, RomanToInteger.romanToInteger("MCMXCIV"));
    //}
}
