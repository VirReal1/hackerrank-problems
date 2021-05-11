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

    // Append and Delete Problem
    public static string appendAndDelete(string s, string t, int k)
    {
        int common = 0;
        for (int i = 0; i < Math.Min(s.Length,t.Length); i++)
        {
            if (s[i] == t[i])
            {
                common++;
            }

            else
            {
                break;
            }
        }

        if (s.Length + t.Length - 2 * common > k)
        {
            return "No";
        }
        else if ((s.Length + t.Length - 2 * common) % 2 == k % 2)
        {
            return "Yes";
        }
        else if (s.Length + t.Length - k < 0)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}