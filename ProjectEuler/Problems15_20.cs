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
        // https://www.mathblog.dk/project-euler-15/
        public static long ProjectEuler15()
        {
            const int gridSize = 20;
            long paths = 1;

            for (int i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }



            Console.WriteLine();
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

    }
}
