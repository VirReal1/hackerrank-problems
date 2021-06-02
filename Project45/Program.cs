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

    // Non-Divisible Subset Problem
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        int[] remainder = new int[s.Count];

        for (int i = 0; i < s.Count; i++)
        {
            remainder[i] = s[i] % k;
        }

        int[] countOf = new int[k];

        for (int i = 0; i < k; i++)
        {
            countOf[i] = remainder.Count(x => x == i);
        }

        if (k % 2 == 0)
        {
            countOf[k / 2] = Math.Min(countOf[k / 2], 1);
        }

        int count = Math.Min(countOf[0], 1);

        for (int i = 1; i <= k / 2; i++)
        {
            count = count + Math.Max(countOf[i], countOf[k - i]);
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp=> Convert.ToInt32(sTemp)).ToList();

        int result = Result.nonDivisibleSubset(k, s);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}