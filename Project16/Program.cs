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

    // Divisible Sum Pair Problem
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int result = 0;

        for (int i = 0; i<ar.Length-1; i++)
        {
            int sum = ar[i];

            for(int y = 0; i+y<ar.Length-1; y++)
            {
                sum = sum + ar[i + y + 1];

                if(sum % k == 0)
                {
                    result++;
                }
                    sum = ar[i];
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
