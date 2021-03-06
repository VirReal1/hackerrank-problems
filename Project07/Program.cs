﻿using System.CodeDom.Compiler;
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
    // Diagonal Difference Problem
    public static int diagonalDifference(List<List<int>> arr)
    {
        int ltr = 0, rtl = 0, result, y = (arr.Count - 1);
        for (int i = 0; i < arr.Count; i++)
        {
            ltr += arr[i][i];
        }
        for (int i = 0; i < arr.Count; i++)
        {
            do
            {
                rtl += arr[i][y];
                y--;
                break;
            } while (i < arr.Count);
        }
        result = Math.Abs(ltr - rtl);
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
