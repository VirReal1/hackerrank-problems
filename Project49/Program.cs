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
using System.Data.Common;
using System.Diagnostics;

class Result
{

    // ACM ICPC Team Problem
    public static List<int> acmTeam(List<string> topic)
    {
        int max = 0;
        int count = 1;

        for (int i = 0; i < topic.Count - 1; i++)
        {
            for (int y = i + 1; y < topic.Count; y++)
            {
                int subjects = 0;
                for (int z = 0; z < topic[0].Length; z++)
                {
                    if (topic[i][z] == '1' || topic[y][z] == '1')
                    {
                        subjects++;
                    }
                }

                if (subjects > max)
                {
                    max = subjects;
                    count = 1;
                }
                else if (subjects == max)
                {
                    count++;
                }
            }
        }

        return new List<int>() {max, count};
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<string> topic = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic.Add(topicItem);
        }
        List<int> result = Result.acmTeam(topic);

        Console.WriteLine(String.Join("\n", result));
        Console.ReadKey();

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}