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

    // Day of the Programmer Problem
    static string dayOfProgrammer(int year)
    {
        string result = "";

        if (year <= 1917)
        {
            if (year % 4 == 0)
            {
                result = "12.09." + year;
            }

            else
            {
                result = "13.09." + year;
            }
        }

        if (year > 1917 && year < 1919)
        {
            result = "26.09." + year;
        }

        if (year >= 1919)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                result = "12.09." + year;
            }

            else
            {
                result = "13.09." + year;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
