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

class Solution
{

    // Sales by Match Problem
    static int sockMerchant(int n, int[] ar)
    {
        List<string> socks = new List<string>();

        int pairs = 0;

        for (int i = 0; i < n; i++)
        {
            socks.Add(Convert.ToString(ar[i]));
        }

        restart:

        for(int i = 0; i < socks.Count-1; i++)
        {
            for (int y = i+1; y < socks.Count; y++)
            {
                if (socks[i] == socks[y])
                {
                    socks.RemoveAt(y);
                    socks.RemoveAt(i);
                    pairs++;
                    goto restart;
                }
            }
        }
        return pairs;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
