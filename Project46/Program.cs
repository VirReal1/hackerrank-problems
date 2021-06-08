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
using System.Runtime.InteropServices.WindowsRuntime;

class Result
{

    // Jumping on the Clouds Problem
    public static int jumpingOnClouds(List<int> c)
    {
        int count = 0;

        for (int i = 0; i < c.Count - 1; i++)
        {
            if (i < (c.Count - 2) && c[i + 1] == 0 && c[i + 2] == 0)
            {
                count++;
                i = i + 1;
            }

            else if (c[i + 1] == 0)
            {
                count++;
            }

            else if (c[i + 1] == 1)
            {
                count++;
                i = i + 1;
            }
        }

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}