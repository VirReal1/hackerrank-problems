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

    // The Time in Words Problem
    public static string timeInWords(int h, int m)
    {
        string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
            "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };

        string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string result = null;

        if (m == 0)
        {
            result = String.Format("{0} o' clock", units[h]);
        }

        else if (m == 15)
        {
            result = String.Format("quarter past {0}", units[h]);
        }

        else if (m == 1)
        {
            result = String.Format("{0} minute past {1}", units[m], units[h]);
        }

        else if (0 < m && m <= 20)
        {
            result = String.Format("{0} minutes past {1}", units[m], units[h]);
        }

        else if (20 < m && m < 30)
        {
            int ten = m / 10;

            int minutes = m % 10;

            result = String.Format("{0} {1} minutes past {2}", tens[ten], units[minutes], units[h]);
        }

        else if (m == 30)
        {
            result = String.Format("half past {0}", units[h]);
        }
        else if (30 < m && m < 40)
        {
            int ten = (60 - m) / 10;

            int minutes = m % 10;

            result = String.Format("{0} {1} minutes to {2}", tens[ten], units[minutes], units[h + 1]);
        }

        else if (m == 45)
        {
            result = String.Format("quarter to {0}", units[h + 1]);
        }

        else if (m == 59)
        {
            result = String.Format("one minute to {0}", units[h + 1]);
        }

        else if (40 <= m && m < 60)
        {
            result = String.Format("{0} minutes to {1}", units[60 - m], units[h + 1]);
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}