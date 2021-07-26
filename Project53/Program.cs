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

    // Bigger is Greater Problem
    public static string biggerIsGreater(string w)
    {
        string n = null;

        if (w.Length == 1)
        {
            return "no answer";
        }

        for (int i = w.Length - 1; i >= 1; i--)
        {
            for (int y = i - 1; y >= 0; y--)
            {
                if ((int)w[i] > (int)w[y])
                {
                    char[] characters = w.ToArray();

                    char temp = characters[i];

                    characters[i] = characters[y];

                    characters[y] = temp;

                    w = new string(characters);

                    string substring = w.Substring(y + 1);

                    characters = substring.ToArray();
                    Array.Sort(characters);
                    substring = new string(characters);

                    return w.Remove(y + 1) + substring;
                }
            }

            if (i == 1)
            {
                return "no answer";
            }
        }

        return n;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
