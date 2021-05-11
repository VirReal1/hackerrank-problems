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

    // Jumping on the Clouds: Revisited Problem
    static int jumpingOnClouds(int[] c, int k)
    {
        int energy = 100;
        int i = -k;
        do
        {
            i = i + k;
            if (c[(i + k)%(c.Length)] == 1)
            {
                energy = energy - 3;
            }
            else
            {
                energy--;
            }
        } while ((i+k)%(c.Length)!=0);

        return energy;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c, k);
        
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}