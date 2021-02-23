using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    // Simple Array Sum Problem
    static int simpleArraySum(int[] ar)
    {
        int result = 0;
        for (int sum = 0; sum < ar.Length; sum++)
        {
            result = result + ar[sum];
        }
        return result;
    }

    static void Main(string[] arg)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
