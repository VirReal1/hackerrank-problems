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

class Result
{

    // Service Lane Problem
    public static List<int> serviceLane(List<int> width, List<List<int>> cases)
    {
        List<int> results = new List<int>();

        for (int i = 0; i < cases.Count; i++)
        {
            int min = Int32.MaxValue;
            for (int y = cases[i][0]; y <= cases[i][1]; y++)
            {
                if (width[y] < min)
                {
                    min = width[y];
                }
            }

            results.Add(min);
        }

        return results;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

        List<List<int>> cases = new List<List<int>>();

        for (int i = 0; i < t; i++)
        {
            cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
        }

        List<int> result = Result.serviceLane(width, cases);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}