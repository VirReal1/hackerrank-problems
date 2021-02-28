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
    // Between Two Sets Problem

    public static int getLCMValue(List<int> a)
    {
        int minLCM, maxLCM, LCMValue = 0;

        minLCM = a.Min();

        maxLCM = a.Max();

        for (int i = maxLCM; i >= maxLCM; i++)
        {
            if(a.All(x => i % x == 0))
            {
                LCMValue = i;
                break;
            }            
        }
        return LCMValue;
    }
    public static int getGCDValue(List<int> b)
    {
        int minGCD = b.Min();

        int GCDValue = 0;

        List<int> GCD = new List<int>();

        for (int i = minGCD; i <= minGCD; i--)
        {
            if(b.All(x => x % i == 0))
            {
                GCDValue = i;
                break;
            }
        }
        return GCDValue;
    }
    public static int getTotalX(int LCMValue, int GCDValue)
    {
        int total = 0;

        for (int i = 1; (LCMValue * i) <= GCDValue; i++)
        {
            if (GCDValue % (LCMValue * i) == 0)
            {
                total++;
            }
        }
        return total;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int LCM = Result.getLCMValue(arr);

        int GCD = Result.getGCDValue(brr);

        int total = Result.getTotalX(LCM, GCD);

        Console.WriteLine(total);

        Console.ReadLine();

        //textWriter.WriteLine(total);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
