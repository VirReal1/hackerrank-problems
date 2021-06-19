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

    // Encryption Problem
    public static string encryption(string s)
    {
        string result = null;
        
        int row = (int)Math.Floor(Math.Sqrt(s.Length));

        int column = (int)Math.Ceiling(Math.Sqrt(s.Length));

        if (row * column < s.Length)
            row++;

        s = s + string.Concat(Enumerable.Repeat(" ",column-s.Length%column));

        string[] encrypt = new string[row];

        int start = 0;

        for (int i = 0; i < row; i++)
        {
            encrypt[i] = s.Substring(start, column);
            start = start + column;
        }

        for (int i = 0; i < column; i++)
        {
            for (int y = 0; y < row; y++)
            {
                result += encrypt[y][i];
            }

            if (result.Last() != ' ')
                result += ' ';
        }

        return result.TrimStart().TrimEnd();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}