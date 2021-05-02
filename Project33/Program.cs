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

    // Viral Advertising Problem
    public static int viralAdvertising(int n)
    {
        double firstAdd = 5;
        double peopleLiked;
        int cumulative = 0;
        for (int i = 0; i < n; i++)
        {
            peopleLiked = Math.Floor(firstAdd / 2);
            firstAdd = peopleLiked * 3;
            cumulative = cumulative + Convert.ToInt32(peopleLiked);
        }
        return cumulative;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}