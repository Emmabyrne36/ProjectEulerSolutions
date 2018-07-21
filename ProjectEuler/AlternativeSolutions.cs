using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class AlternativeSolutions
    {
        #region ProjectEuler2
        public static int Fib(int n)
        {
            return n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
        }

        public static List<int> series = new List<int>();
        public static void FibSeries(int n)
        {
            bool result = true;
            while (result)
            {
                result = FibTemp(1, 2, 1, n);
            }
        }


        public static bool FibTemp(int a, int b, int counter, int length)
        {
            if (counter <= length)
            {
                if (a % 2 == 0 && !(a >= 4000000) && !(b >= 4000000))
                {
                    series.Add(a);
                    FibTemp(b, a + b, counter + 1, length);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region ProjectEuler3
        public static long ProjEuler3OtherSolution()
        {
            long n = 600851475143;
            while (true)
            {
                long p = SmallestFactor(n);
                if (p < n)
                {
                    n /= p;
                }
                else
                {
                    return n;
                }
            }
        }

        // Returns the smallest factor of n, which is in the range [2, n]. The result is always prime.
        public static long SmallestFactor(long n) // from online solution
        {
            if (n <= 1)
            {
                n = 1;
            }

            for (long i = 2, end = Convert.ToInt64(Math.Sqrt(n)); i <= end; i++)
            {
                if (n % i == 0)
                {
                    return i;
                }
            }
            return n;
        }
        #endregion

        #region ProjectEuler4
        public static bool IsPalindrome2(int n)
        {
            char[] characterArray = n.ToString().ToCharArray();
            for (int i = 0; i <= (characterArray.Length / 2); i++)
            {
                if (characterArray[i] != characterArray[(characterArray.Length - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

    }
}
