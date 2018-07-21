using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ProjEuler1());
            Console.WriteLine(ProjEuler2());
            Console.WriteLine(ProjEuler3());
            Console.WriteLine(ProjEuler4_WhileLoop());
            Console.WriteLine(ProjEuler5());
            Console.Read();
        }

        #region ProjEuler1
        public static int ProjEuler1() // Multiples of 3 and 5
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

        #region ProjEuler2
        public static int ProjEuler2() // Even Fibonacci numbers
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

        #region ProjEuler3
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // Get largest prime factor of 600851475143
        public static long ProjEuler3()
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

        #region ProjEuler4
        public static int ProjEuler4_WhileLoop() // LargestPalindromeProduct
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

        public static int ProjEuler4_ForLoop()
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

        #region ProjeEuler5
        public static int ProjEuler5() // Smallest multiple
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
    }
}