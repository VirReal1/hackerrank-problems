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
using System.Runtime.CompilerServices;
using System.Xml.Schema;

class Result
{
    // Picking Numbers Problem
    public static int pickingNumbers(List<int> a)
    {
        List<int> numbers = new List<int>();
        int max = 0;
        for (int i = 0; i < a.Count; i++)
        {
            numbers.Clear();
            numbers.Add(a[i]);
            for (int y = 0; y < a.Count; y++)
            {
                if (i == y)
                {
                    continue;
                }
                else if (numbers.All(number => Math.Abs(number-a[y])<=1))
                {
                    numbers.Add(a[y]);
                }
            }

            if (numbers.Count > max)
            {
                max = numbers.Count;
            }
        }
        return max;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}