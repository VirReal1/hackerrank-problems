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
using System.Xml.Schema;

class Result
{

    // Beautiful Days at the Movies Problem
    public static int beautifulDays(int i, int j, int k)
    {
        int numberOfDays = 0;
        for (int z = i; z <= j; z++)
        {
            int reverseNumber = 0, rem, n = z;

            while (n != 0)
            {
                rem = n % 10;
                reverseNumber = reverseNumber * 10 + rem;
                n = n / 10;
            }

            if ((z - reverseNumber) % k == 0)
            {
                    numberOfDays++;
            }
        }

        return numberOfDays;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);
        Console.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}