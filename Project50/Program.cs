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
using System.Data.SqlClient;
using System.Runtime.Remoting;

class Result
{

    // Taum and B'day Problem
    public static long taumBday(long b, long w, long bc, long wc, long z)
    {
        long cost = 0;

        if (wc >= bc)
        {
            if (wc - bc >= z)
            {
                cost = bc * b + (bc + z) * w;
            }
            else if (wc - bc < z)
            {
                cost = bc * b + wc * w;
            }
        }
        else if (bc > wc)
        {
            if (bc - wc >= z)
            {
                cost = wc * w + (wc + z) * b;
            }
            else if (wc - bc < z)
            {
                cost = wc * w + bc * b;
            }
        }

        return cost;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt32(Console.ReadLine().Trim());

        for (long tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long b = Convert.ToInt32(firstMultipleInput[0]);

            long w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long bc = Convert.ToInt32(secondMultipleInput[0]);

            long wc = Convert.ToInt32(secondMultipleInput[1]);

            long z = Convert.ToInt32(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}