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

    // Apple and Orange Problem

    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int applesCloseDistance = s - a;

        int applesFarDistance = t - a;

        int orangesCloseDistance = b - t;

        int orangesFarDistance = b - s;

        int applesDropped = 0;

        int orangesDropped = 0;

        for(int i = 0; i<apples.Length; i++)
        {
            if (apples[i] > 0)
            {
                if (apples[i] >= applesCloseDistance && apples[i] <= applesFarDistance)
                {
                    applesDropped++;
                }
            }
        }

        for(int i = 0; i<oranges.Length; i++)
        {
            if (oranges[i] < 0)
            {
                oranges[i] = Math.Abs(oranges[i]);
                if (oranges[i] >= orangesCloseDistance && oranges[i] <= orangesFarDistance)
                {
                    orangesDropped++;
                }
            }
        }

        Console.WriteLine(applesDropped);

        Console.WriteLine(orangesDropped);
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' '); //Home Range

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]); // Apple location

        int b = Convert.ToInt32(ab[1]); // Orange location

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]); // Number of apples

        int n = Convert.ToInt32(mn[1]); // Number of oranges

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp)); // Apples fall range

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp)); // Oranges fall range

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
