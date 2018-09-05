using System;
using System.Collections;
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
                if (Utilities.isPrime(i))
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
            // Ideas for obtaining the GCD and LCM obtained from http://csharphelper.com/blog/2014/08/calculate-the-greatest-common-divisor-gcd-and-least-common-multiple-lcm-of-two-integers-in-c/
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
            // Sum square difference
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
        // 10001st prime number
        #region ProjectEuler7
        public static long ProjectEuler7()
        {
            // 10,001st prime number
            long result = 0;
            long count = 0;
            for (long i = 2; count < 10001; i++)
            {
                if (Utilities.isPrime(i))
                {
                    result = i;
                    count++;
                }
            }

            return result;
        }
        #endregion

        //======================================== Problem 8 ==========================================================
        // Largest product in a series
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
                    current *= (int)char.GetNumericValue(j);
                }

                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
        #endregion

        //======================================== Problem 9 ==========================================================
        // Special Pythagorean triplet
        #region ProjectEuler9
        public static double ProjectEuler9()
        {
            /*
             * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a**2 + b**2 = c**2
             * For example, 3**2 + 4**2 = 9 + 16 = 25 = 5**2. --> a = 3, b = 4, c = 5
             */
            // Ideas fo generating the correct pythagorean tripled obtained from https://www.mathblog.dk/pythagorean-triplets/
            int c = 0;
            int final = 1000;
            int product = 0;

            // a < b < c; therefore a < 1000 / 3,  and a < b < 1000 / 2.
            for (int a = 1; a < final/3; a ++)
            {
                for (int b = a + 1; b < final / 2; b++)
                {
                    c = final - a - b; // c is the remainder of 1000 - a - b
                    if (IsPythagoreanTriplet(a, b, c) && ((a + b + c) == 1000))
                    {
                        product = a * b * c;
                        break;
                    }
                }
            }
            return product;
        }

        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
           //  A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a**2 + b**2 = c**2
            if (a < b && b < c)
            {
                if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2)) {
                    return true;
                }
            }
            return false;
        }
        #endregion

        //======================================== Problem 10 ==========================================================
        // Summation of primes
        #region ProjectEuler10
        public static long ProjectEuler10()
        {
            // Find the sum of all the primes below two million
            // Implementing the Sieve of Eratosthenes algorithm
            long[] primeNumbers = OptimizedSieve(2000000);

            long sumValues = 0;
            for (long i = 0; i < primeNumbers.Length; i++)
            {
                sumValues += primeNumbers[i];
            }

            return sumValues;
        }
        public static long[] OptimizedSieve(int n)
        {
            // So, if the number is 9999, we go from 1 to 5000, multiply each number by 2 to make it even and add one.
            // This gives us a list of all odd numbers, which reduces the iterations through the sieve.
            /*
             * eg
                var upperLimit = 9999;
                List<Int64> primes = new List<Int64>();
                for (int x = 2; x <= (upperLimit + 1) / 2; x++)
                    primes.Add(2 * x + 1);
            */
            // Ideas for obtimising the Sive() method below obtained from https://www.mathblog.dk/sum-of-all-primes-below-2000000-problem-10/
            int sieveBound = (n - 1) / 2;
            BitArray bitArr = new BitArray(sieveBound, true);
            int limit = ((int)Math.Sqrt(n) - 1) / 2;

            for (int i = 1; i <= limit; i++)
            {
                if (bitArr.Get(i))
                {
                    for (int j = 2 * i * (i + 1); j < sieveBound; j += 2 * i + 1)
                    {
                        bitArr.Set(j, false);
                    }
                }
            }

            List<long> finalList = new List<long>();
            finalList.Add(2);
            for (int i = 1; i < bitArr.Length; i++)
            {
                if (bitArr.Get(i))
                {
                    finalList.Add(2 * i + 1);
                }
            }

            return finalList.ToArray();
        }

        public static long[] Sieve(int n)
        {
            BitArray bitArr = new BitArray(n, true);

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (bitArr.Get(i))
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        bitArr.Set(j, false);
                    }
                }
            }

            List<long> finalList = new List<long>();
            for (int i = 2; i < bitArr.Length; i++)
            {
                if (bitArr.Get(i))
                {
                    finalList.Add(i);
                }
            }

            return finalList.ToArray();
        }
        #endregion
    }
}
