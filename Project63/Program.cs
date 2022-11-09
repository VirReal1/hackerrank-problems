﻿using System.CodeDom.Compiler;
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

    // Cavity Map Problem
    public static List<string> cavityMap(List<string> grid)
    {
        for (int i = 1; i < grid.Count - 1; i++)
        {
            for (int j = 1; j < grid.Count - 1; j++)
            {
                if (Convert.ToInt32(grid[i][j]) > Convert.ToInt32(grid[i][j - 1]) && Convert.ToInt32(grid[i][j]) > Convert.ToInt32(grid[i][j + 1]) && Convert.ToInt32(grid[i][j]) > Convert.ToInt32(grid[i - 1][j]) && Convert.ToInt32(grid[i][j]) > Convert.ToInt32(grid[i + 1][j]))
                {
                    StringBuilder temp = new StringBuilder(grid[i]);
                    temp[j] = 'X';
                    grid[i] = temp.ToString();
                }
            }
        }

        return grid;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> grid = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = Result.cavityMap(grid);
        Console.WriteLine();
        Console.WriteLine(String.Join("\n", result));

        Console.ReadKey();

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}