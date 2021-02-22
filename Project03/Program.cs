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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        double minus = 0, add = 0, equal = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                minus++;
            }
            else if (arr[i] > 0)
            {
                add++;
            }
            else if (arr[i] == 0)
            {
                equal++;
            }
        }

        Console.WriteLine(Convert.ToDouble(add / arr.Length).ToString("F6"));
        Console.WriteLine(Convert.ToDouble(minus / arr.Length).ToString("F6"));
        Console.WriteLine(Convert.ToDouble(equal / arr.Length).ToString("F6"));

        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        plusMinus(arr);
    }
}
