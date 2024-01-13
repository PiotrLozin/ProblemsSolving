using ProblemsSolving.TopInterview150.Easy;
using System.Text;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class IntegerToRoman
    {
        public static string integerToRoman(int num)
        {
            var romanNumberBuilder = new StringBuilder();
            Dictionary<int, string> romansMap = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

            foreach (var romanInt in romansMap.Keys)
            {
                while(romanInt <= num )
                {
                    romanNumberBuilder.Append(romansMap[romanInt]);
                    num -= romanInt;
                }
            }

            var romanNumber = romanNumberBuilder.ToString();
            return romanNumber;
        }
    }

    //public static void Main(string[] args)
    //{
    //    Assert.Equal("III", IntegerToRoman.integerToRoman(3));
    //    Assert.Equal("LVIII", IntegerToRoman.integerToRoman(58));
    //    Assert.Equal("MCMXCIV", IntegerToRoman.integerToRoman(1994));
    //}
}
