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

    // Counting Valleys Program
    public static int countingValleys(int steps, string path)
    {
        int pathWay = 0, numberOfValleys = 0;

        for (int i = 0; i < steps; i++)
        {
            if (path[i] == 'D')
            {
                pathWay++;
            }

            else if(path[i] == 'U')
            {
                pathWay--;
            }

            if (pathWay == 0 && path[i] == 'U')
            {
                numberOfValleys++;
            }
        }
        return numberOfValleys;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
