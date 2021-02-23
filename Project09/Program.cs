using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    // Time Conversion Problem
    static string timeConversion(string s)
    {
        string result = "";

        int hour = Int32.Parse(s.Substring(0, 2));

        string min = s.Substring(3, 2);

        string sec = s.Substring(6, 2);

        string format = s.Substring(8, 2);

        if (hour == 12 && format == "PM")
        {
            result = hour + ":" + min + ":" + sec;
        }
        else if (hour == 12 && format == "AM")
        {
            result = "00" + ":" + min + ":" + sec;
        }
        else if (hour < 12 && format == "AM")
        {
            if (hour < 10)
            {
                result = "0" + hour + ":" + min + ":" + sec;
            }
            else
            {
                result = hour + ":" + min + ":" + sec;
            }
        }
        else if (hour < 12 && format == "PM")
        {
            result = (hour + 12) + ":" + min + ":" + sec;
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
