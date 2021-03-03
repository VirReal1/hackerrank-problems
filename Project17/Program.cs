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

    // Migratory Birds Problem
    static int migratoryBirds(List<int> arr)
    {
        int[] repeat = { 0, 0, 0, 0, 0 };

        int max = 0;

        int birdRepeat = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            repeat[arr[i] - 1]++;
        }

        for (int x = 0; x < repeat.Length; x++)
        {
            if (repeat[x] > max)
            {
                max = repeat[x];
                birdRepeat = x + 1;
            }
        }

        return birdRepeat;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
