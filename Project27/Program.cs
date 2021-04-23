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
using System.Xml.Schema;

class Result
{

    // Designer PDF Viewer Problem
    public static int designerPdfViewer(List<int> h, string word)
    {
        string keys = "abcdefghijklmnopqrstuvwxyz";
        int min = 0;
        int max = 0;

        for(int i = 0; i < word.Length; i++)
        {
            for (int y = 0; y < 27; y++)
            {
                if (word[i] == keys[y])
                {
                    min = h[y];
                    if (min > max)
                    {
                        max = min;
                    }

                    break;
                }
            }
        }
        return (max*word.Length);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}