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

    // Beautiful Triplets Problem  
    public static int beautifulTriplets(int d, List<int> arr)
    {
        int numberOfTriplets = 0;

        for (int i = 1; i <= arr.Count - 1; i++)
        {
            int temp1 = -1;
            int temp2 = -1;
            if (arr.Contains(arr[i] - d))
            {
                if (arr.Contains(arr[i] + d))
                {
                    foreach (var number in arr)
                    {
                        if (number == arr[i] - d)
                        {
                            temp1++;
                        }

                        if (number == arr[i] + d)
                        {
                            temp2++;
                        }
                    }
                    numberOfTriplets = numberOfTriplets + 1 + temp1 + temp2;
                }
            }
        }

        return numberOfTriplets;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}