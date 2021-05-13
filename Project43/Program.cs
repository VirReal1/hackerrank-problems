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
using System.CodeDom;
using System.Xml;

class Result
{

    // Cut the Sticks Problem
    public static List<int> cutTheSticks(List<int> arr)
    {
        List<int> numberOfSticks = new List<int>();
        numberOfSticks.Add(arr.Count);
        int count = arr.Count;
        for (int i = 0; i < count; i++)
        {
            arr = arr.Select(x => x - arr.Min()).ToList();
            arr.RemoveAll(x => x == 0);
            if (arr.Count == 0)
            {
                break;
            }
            numberOfSticks.Add(arr.Count);
            if (arr.TrueForAll(o => o == arr[0]))
            {
                break;
            }
        }
        return numberOfSticks;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Close();
    }
}