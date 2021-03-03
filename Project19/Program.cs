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

    // Bill Division Problem
    static void bonAppetit(List<int> bill, int k, int b)
    {
        int sum = 0;
        for(int i = 0; i<bill.Count; i++)
        {
            sum += bill[i];
        }

        sum -= bill[k];

        if (b == (sum/2))
        {
            Console.WriteLine("Bon Appetit");
        }

        else
        {
            Console.Write(bill[k]/2);
        }
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]); // number of items

        int k = Convert.ToInt32(nk[1]); // which she didn't eat

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim()); //how much anna payed

        bonAppetit(bill, k, b);
    }
}
