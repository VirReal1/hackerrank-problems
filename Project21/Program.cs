using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    
    // Drawing Book Problem
    static int pageCount(int n, int p)
    {
        int pageNumber = p / 2;

        int begin = 0, beginCount = 0;

        int end = n / 2, endCount = 0;

        if (pageNumber == begin || pageNumber == end)
        {
            return 0;
        }

        else
        {
            do
            {
                begin++;

                beginCount++;
            } while (begin != pageNumber);

            do
            {
                end--;

                endCount++;
            } while (end != pageNumber);
        }

        if (beginCount < endCount)
        {
            return beginCount;
        }
        else
        {
            return endCount;
        }

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
