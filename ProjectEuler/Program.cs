using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ProjectEuler1());
            Console.WriteLine(ProjectEuler2());
            Console.WriteLine(ProjectEuler3());
            Console.WriteLine(ProjectEuler4_WhileLoop());
            Console.WriteLine(ProjectEuler5());
            Console.WriteLine(ProjectEuler6());
            Console.Read();
        }
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
            return primeFactors.Max();
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
    }
}