using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Security.Cryptography;

class Result
{

    // Modified Kaprekar Numbers Problem
    public static void kaprekarNumbers(long p, long q)
    {
        List<long> results = new List<long>();

        for (long i = p; i <= q; i++)
        {
            long baseNumber = i;

            long temp = i * i;

            if (Math.Floor(Math.Log10(temp) + 1) % 2 == 0)
            {
                long sum = 0;
                int numberOfDigits = (int)Math.Floor(Math.Log10(temp) + 1);
                int secondHalf = (int)Math.Floor(Math.Log10(temp) + 1) / 2;

                sum = temp % (long)Math.Pow(10, secondHalf) + temp / (long)Math.Pow(10,numberOfDigits - secondHalf);

                if (sum == baseNumber)
                {
                    results.Add(sum);
                }
            }

            else if (Math.Floor(Math.Log10(temp) + 1) % 2 == 1)
            {
                long sum = 0;
                int numberOfDigits = (int)Math.Floor(Math.Log10(temp) + 1);
                int secondHalf = (int)Math.Floor(Math.Log10(temp) + 2) / 2;

                sum = temp % (long)Math.Pow(10, secondHalf) + temp / (long)Math.Pow(10, numberOfDigits - secondHalf + 1);

                if (sum == baseNumber)
                {
                    results.Add(sum);
                }
            }
        }

        if (results.Any() == false)
        {
            Console.WriteLine("INVALID RANGE");
        }

        foreach (var result in results)
        {
            Console.Write("{0} ", result);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        long p = Convert.ToInt32(Console.ReadLine().Trim());

        long q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}