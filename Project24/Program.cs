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

    // Cats and a Mouse Problem
    static string catAndMouse(int x, int y, int z)
    {
        int cat1Distance = Math.Abs(x - z);

        int cat2Distance = Math.Abs(y - z);

        string winner = "";

        if (cat1Distance == cat2Distance)
        {
            winner = "Mouse C";
        }
        
        else if (cat1Distance > cat2Distance)
        {
            winner = "Cat B";
        }

        else if (cat1Distance < cat2Distance)
        {
            winner = "Cat A";
        }

        return winner;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}