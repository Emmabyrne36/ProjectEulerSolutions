using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectEuler
{
    public class Problems1_10
    {
        //======================================== Problem 1 ==========================================================
        #region ProjectEuler1
        public static int ProjectEuler1() // Multiples of 3 and 5
        {

            int totalSum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalSum += i;
                }
            }

            return totalSum;
        }
        #endregion

        //======================================== Problem 2 ==========================================================
        #region ProjectEuler2
        public static int ProjectEuler2() // Even Fibonacci numbers
        {
            int first = 0, next = 1, result = 0, sumValues = 0;

            while (result < 4000000)
            {
                result = first + next;
                first = next;
                next = result;
                if (result % 2 == 0)
                {
                    sumValues += result;
                }
            }
            return sumValues;
        }
        #endregion

        //======================================== Problem 3 ==========================================================
        #region ProjectEuler3
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // Get largest prime factor of 600851475143
        public static long ProjectEuler3()
        {
            long n = 600851475143;
            List<long> primeFactors = new List<long>();
            for (long i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    while (n % i == 0)
                    {
                        primeFactors.Add(i);
                        n /= i;
                    }
                }
            }
            return primeFactors.Max(); // using System.Linq
        }

        public static bool isPrime(long n)
        {
            bool primeValue = true;
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    primeValue = false;
                    break;
                }
            }
            return primeValue;
        }

        #endregion

        //======================================== Problem 4 ==========================================================
        #region ProjectEuler4
        public static int ProjectEuler4_WhileLoop() // LargestPalindromeProduct
        {
            /*
            * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            * Find the largest palindrome made from the product of two 3-digit numbers.
            */

            int n, maxNum = 0;
            int i = 100, j = 100;
            while (j < 1000)
            {
                if (i == 999)
                {
                    i = 100;
                    j++;
                }
                n = i * j;
                if (n > maxNum && IsPalindrome(n))
                {
                    maxNum = n;
                }
                i++;
            }
            return maxNum;
        }

        public static int ProjectEuler4_ForLoop()
        {
            int i, j, result, maxNum = 0;

            for (i = 100; i <= 999; i++)
            {
                for (j = 100; j <= 999; j++)
                {
                    result = i * j;
                    if (result > maxNum && IsPalindrome(result))
                    {
                        maxNum = result;
                    }
                }
            }

            return maxNum;
        }
        public static bool IsPalindrome(int n)
        {
            string numberString = n.ToString();
            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        //======================================== Problem 5 ==========================================================
        #region ProjectEuler5
        public static int ProjectEuler5() // Smallest multiple
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
            int res = 1;
            for (int i = 1; i <= 20; i++)
            {
                res = LCM(res, i);
            }
            return res;
        }

        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a == 0 ? b : a;
        }

        public static int LCM(int a, int b)
        {
            // Get the prime factors
            return a / GCD(a, b) * b;
        }
        #endregion

        //======================================== Problem 6 ==========================================================
        #region ProjectEuler6
        public static double ProjectEuler6()
        {
            double totalSumOfSquares = 0;
            double totalSquareOfSums = 0;
            for (int i = 1; i <= 100; i++)
            {
                totalSumOfSquares += Math.Pow(i, 2);
                totalSquareOfSums += i;
            }

            return Math.Pow(totalSquareOfSums, 2) - totalSumOfSquares;
        }
        #endregion

        //======================================== Problem 7 ==========================================================
        #region ProjectEuler7
        public static long ProjectEuler7()
        {
            // 10,001st prime number
            long result = 0;
            long count = 0;
            for (long i = 2; count < 10001; i++)
            {
                if (isPrime(i)) // use the isPrime method from Problem 3
                {
                    result = i;
                    count++;
                }
            }

            return result;
        }
        #endregion

        //======================================== Problem 8 ==========================================================
        #region ProjectEuler8
        public static long ProjectEuler8()
        {
            // The four adjacent digits in the 1000 - digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832
            string number = @"73167176531330624919225119674426574742355349194934
                            96983520312774506326239578318016984801869478851843
                            85861560789112949495459501737958331952853208805511
                            12540698747158523863050715693290963295227443043557
                            66896648950445244523161731856403098711121722383113
                            62229893423380308135336276614282806444486645238749
                            30358907296290491560440772390713810515859307960866
                            70172427121883998797908792274921901699720888093776
                            65727333001053367881220235421809751254540594752243
                            52584907711670556013604839586446706324415722155397
                            53697817977846174064955149290862569321978468622482
                            83972241375657056057490261407972968652414535100474
                            82166370484403199890008895243450658541227588666881
                            16427171479924442928230863465674813919123162824586
                            17866458359124566529476545682848912883142607690042
                            24219022671055626321111109370544217506941658960408
                            07198403850962455444362981230987879927244284909188
                            84580156166097919133875499200524063689912560717606
                            05886116467109405077541002256983155200055935729725
                            71636269561882670428252483600823257530420752963450";

            number = Regex.Replace(number, @"\s+", ""); // remove any white space in the number

            int length = 13;
            long max = 0;
            for (int i = 0; i <= (number.Length)-length; i++)
            {
                string subString = number.Substring(i, length);
                long current = 1;
                foreach (var j in subString)
                {
                    current *= (int)Char.GetNumericValue(j);
                }

                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
        #endregion
    }
}
