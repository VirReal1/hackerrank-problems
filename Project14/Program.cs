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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int min = 0, max = 0, minPoint = 0, maxPoint = 0;

        int[] result = new int[1];

        min = scores[0];

        max = min;

        for(int i = 0; i<scores.Length; i++)
        {
            if (scores[i] < min)
            {
                min = scores[i];

                minPoint++;
            }
            else if (scores[i] > max)
            {
                max = scores[i];

                maxPoint++;
            }
        }

        result[0] = minPoint;

        result[1] = maxPoint;

        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

        int[] result = breakingRecords(scores);

        Console.WriteLine(string.Join(" ", result));

        Console.ReadLine();

        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
