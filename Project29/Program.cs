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
using System.Runtime.Remoting.Messaging;

class Result
{

    // Climbing the Leaderboard Problem
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> result = new List<int>();
        List<int> ranking = ranked.Distinct().ToList();
        int shortCut = 0;

        for (int i = player.Count-1; i >= 0; i--)
        {
            for (int y = shortCut; y<ranking.Count; y++)
            {
                if (player[i] >= ranking[y])
                {
                    result.Add(y+1);
                    shortCut = y;
                    break;
                }
                else if(player[i]<ranking[ranking.Count-1])
                {
                    result.Add(ranking.Count+1);
                    break;
                }
            }
        }
        result.Sort((a,b) => b.CompareTo(a));
        return result;
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}