﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    // Electronics Shop Problem
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int max = -1;

        for (int i = keyboards.Length-1; i >= 0; i--)
        {
            for (int y = 0; y < drives.Length; y++)
            {
                int price = 0;

                price = keyboards[i] + drives[y];

                if (price > max && price <= b)
                {
                    max = price;
                }
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
        
        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
