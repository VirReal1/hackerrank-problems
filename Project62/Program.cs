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
using System.Security.Cryptography.X509Certificates;

class Result
{

    // Fair Rations Problem
    public static string fairRations(List<int> B)
    {
        int numberOfBreads = 0;

        if (B.Count == 2 && B.Exists(x => x % 2 == 0))
            return "NO";

        for (int i = 0; i < B.Count - 1; i++)
        {
            if (B[i] % 2 != 0)
            {
                B[i]++;
                B[i + 1]++;
                numberOfBreads += 2;
            }
        }

        if (B.Exists(x => x % 2 != 0))
            return "NO";

        return numberOfBreads.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

        string result = Result.fairRations(B);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}