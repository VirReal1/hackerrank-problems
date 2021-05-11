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

    // Sequence Equation Problem
    public static List<int> permutationEquation(List<int> p)
    {
        List<int> first = new List<int>();

        List<int> second = new List<int>();

        for (int i = 0; i < p.Count; i++)
        {
            for (int y = 0; y < p.Count; y++)
            {
                if (i+1 == p[y])
                {
                    first.Add(y+1);
                }
            }
        }

        for (int i = 0; i < p.Count; i++)
        {
            for (int y = 0; y < p.Count; y++)
            {
                if (first[i] == p[y])
                {
                    second.Add(y + 1);
                }
            }
        }

        return second;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

        List<int> result = Result.permutationEquation(p);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}