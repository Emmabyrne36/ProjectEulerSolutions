﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectEuler
{
    public class Utilities
    {
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
    }
}
