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
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Result
{

    // Queen's Attack II Problem
    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        int numberOfMoves = 0;

        if (obstacles.Any(x => x[0] == r_q && x[1] > c_q)) // Right Row
        {
            numberOfMoves += obstacles.Where(x => x[0] == r_q).Select(x => x[1]).Where(x => x > c_q).Min() - c_q - 1;
        }
        else
        {
            numberOfMoves += n - c_q;
        }

        if (obstacles.Any(x => x[0] == r_q && x[1] < c_q)) // Left Row
        {
            numberOfMoves += c_q - 1 - obstacles.Where(x => x[0] == r_q).Select(x => x[1]).Where(x => x < c_q).Max();
        }
        else
        {
            numberOfMoves += c_q - 1;
        }


        if (obstacles.Any(x => x[1] == c_q && x[0] > r_q)) // Top Column
        {
            numberOfMoves += obstacles.Where(x => x[1] == c_q).Select(x => x[0]).Where(x => x > r_q).Min() - r_q - 1;
        }
        else
        {
            numberOfMoves += n - r_q;
        }

        if (obstacles.Any(x => x[1] == c_q && x[0] < r_q)) // Bottom Column
        {
            numberOfMoves += r_q - 1 - obstacles.Where(x => x[1] == c_q).Select(x => x[0]).Where(x => x < r_q).Max();
        }
        else
        {
            numberOfMoves += r_q - 1;
        }


        if (obstacles.Any(x => x[0] - r_q > 0 && x[1] - c_q > 0 && x[0] - r_q == x[1] - c_q)) // Top Right
        {
            numberOfMoves += obstacles.Where(x => x[0] - r_q > 0 && x[1] - c_q > 0 && x[0] - r_q == x[1] - c_q).Select(x => x[0] - r_q).Min() - 1;
        }
        else
        {
            numberOfMoves += Math.Min(n - r_q, n - c_q);
        }

        if (obstacles.Any(x => x[0] - r_q > 0 && x[1] - c_q < 0 && x[0] - r_q == c_q - x[1])) // Top Left
        {
            numberOfMoves += obstacles.Where(x => x[0] - r_q > 0 && x[1] - c_q < 0 && x[0] - r_q == c_q - x[1]).Select(x => x[0] - r_q).Min() - 1;
        }
        else
        {
            numberOfMoves += Math.Min(n - r_q, c_q - 1);
        }


        if (obstacles.Any(x => x[0] - r_q < 0 && x[1] - c_q > 0 && x[0] - r_q == c_q - x[1])) // Bottom Right
        {
            numberOfMoves += obstacles.Where(x => x[0] - r_q < 0 && x[1] - c_q > 0 && x[0] - r_q == c_q - x[1]).Select(x => r_q - x[0]).Min() - 1;
        }
        else
        {
            numberOfMoves += Math.Min(r_q - 1, n - c_q);
        }

        if (obstacles.Any(x => x[0] - r_q < 0 && x[1] - c_q < 0 && x[0] - r_q == x[1] - c_q)) // Bottom Left
        {
            numberOfMoves += obstacles.Where(x => x[0] - r_q < 0 && x[1] - c_q < 0 && x[0] - r_q == x[1] - c_q).Select(x => r_q - x[0]).Min() - 1;
        }
        else
        {
            numberOfMoves += Math.Min(c_q - 1, r_q - 1);
        }


        return numberOfMoves;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]); // Board Row and Column

        int k = Convert.ToInt32(firstMultipleInput[1]); // Number of Obstacles

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r_q = Convert.ToInt32(secondMultipleInput[0]); // Queen Row

        int c_q = Convert.ToInt32(secondMultipleInput[1]); // Queen Column

        List<List<int>> obstacles = new List<List<int>>(); // Row and Column of Obstacles

        for (int i = 0; i < k; i++)
        {
            obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
        }

        int result = Result.queensAttack(n, k, r_q, c_q, obstacles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}