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

class Result
{

    // Lisa's Workbook Problem
    public static int workbook(int n, int k, List<int> arr)
    {
        List<int> pages = new List<int>();

        int specialProblems = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] / k >= 1)
            {
                for (int y = 0; y < arr[i] / k; y++)
                {
                    pages.Add(k + k * y);
                    if (y + 1 == arr[i] / k && arr[i] % k != 0)
                    {
                        pages.Add(k * (y + 1) + arr[i] % k);
                    }
                }
            }
            else
            {
                pages.Add(arr[i]);
            }
        }

        for (int i = 0; i < pages.Count; i++)
        {
            for (double y = Math.Ceiling(Convert.ToDouble(pages[i]) / Convert.ToDouble(k)) * k - k + 1; y <= Math.Ceiling(Convert.ToDouble(pages[i]) / Convert.ToDouble(k)) * k; y++)
            {
                if (y == i + 1)
                {
                    specialProblems++;
                }

                if (y == pages[i])
                {
                    break;
                }
            }

        }

        return specialProblems;
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

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}