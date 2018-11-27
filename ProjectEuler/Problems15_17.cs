using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler
{
    public class Problems15_20
    {
        //======================================== Problem 15 ==========================================================
        // Lattice Paths
        #region ProjectEuler15
        // Ideas for this solution obtained from https://www.mathblog.dk/project-euler-15/
        public static long ProjectEuler15()
        {
            const int gridSize = 20;
            long paths = 1;

            for (int i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }
            return paths;
        }


        #endregion

        //======================================== Problem 16 ==========================================================
        // Power Digit Sum
        #region ProjectEuler16
        public static int ProjectEuler16()
        {
            // Math.Pow(2, 1000) is too big for a long. Need to use the BigInteger like in Problem 13
            BigInteger result = BigInteger.Pow(2, 1000);
            // Using LINQ, split the result into an array of individual numbers
            List<int> digitList = result.ToString().Select(s => int.Parse(s.ToString())).ToList();
            int sumValues = digitList.Sum();
            return sumValues;
        }
        #endregion

        //======================================== Problem 17 ==========================================================
        // Number letter counts
        #region ProjectEuler17
        public static long ProjectEuler17()
        {

            StringBuilder result = new StringBuilder();
            for (int i = 1; i < 1001; i++)
            {
                result.Append(ConvertNumbersToWords(i));
            }

            return result.Length;
        }

        public static string ConvertNumbersToWords(int number)
        {
            // Ideas for splitting up the numbers using / and % obtained from https://stackoverflow.com/questions/2729752/converting-numbers-in-to-words-c-sharp
            string[] units = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            StringBuilder sb = new StringBuilder();

            // If the number is in the thousands
            if ((number / 1000) > 0)
            {
                // Pass the first part of the number back into the method eg: 1200 will pass 1 into the method to get 'one' and the remainder, 200 will be then processed
                // getting an answer of one thousand and twenty (but with spaces removed)
                sb.Append(ConvertNumbersToWords(number / 1000) + "thousand");
                number %= 1000; // Get the remainder of the number to be used in the rest of the method
            }

            // If the number is in the hundreds
            if ((number / 100) > 0)
            {
                // Follow same methodology as above
                sb.Append(ConvertNumbersToWords(number / 100) + "hundred");
                number %= 100;
            }

            if (number > 0)
            {
                // Don't add for the thousand though
                if (!string.IsNullOrEmpty(sb.ToString())) // add the 'and' if the above methods have added values to the stringbuilder
                {
                    sb.Append("and");
                }

                // Split up the number
                if (number < 20)
                {
                    sb.Append(units[number - 1]);
                }
                else
                {
                    sb.Append(tens[(number / 10) - 1]);
                    if ((number % 10) > 0) // if the second number is greater than 0 - i.e. if the number is 21 - the second number will be 1 etc.
                    {
                        sb.Append(units[(number % 10) - 1]);
                    }
                }
            }

            return sb.ToString();
        }
        #endregion
    }
}
