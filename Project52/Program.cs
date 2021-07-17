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

    // Organizing Containers of Balls Problem
    public static string organizingContainers(List<List<int>> container)
    {

        int[] ballsInContainers = new int[container.Count];

        int[] typeOfBalls = new int[container.Count];

        for (int i = 0; i < container.Count; i++)
        {
            for (int y = 0; y < container.Count; y++)
            {
                ballsInContainers[i] += container[i][y];
            }
        }

        for (int i = 0; i < container.Count; i++)
        {
            for (int y = 0; y < container.Count; y++)
            {
                typeOfBalls[i] += container[y][i];
            }
        }

        Array.Sort(ballsInContainers);
        Array.Sort(typeOfBalls);

        if (Enumerable.SequenceEqual(typeOfBalls, ballsInContainers))
        {
            return "Possible";
        }

        return "Impossible";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> container = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
            }

            string result = Result.organizingContainers(container);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}