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
using System.Diagnostics.Tracing;

class Result
{

    // Minimum Distances Problem
    public static int minimumDistances(List<int> a)
    {
        int minNum = Int32.MaxValue;

        int temp = 0;
        for (int i = 0; i < a.Count - 1; i++)
        {
            for (int y = i + 1; y < a.Count; y++)
            {
                if (a[i] == a[y])
                {
                    temp = y - i;

                    if (temp < minNum)
                    {
                        minNum = temp;
                    }
                }
            }
        }

        if (minNum == Int32.MaxValue)
        {
            return -1;
        }

        return minNum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}