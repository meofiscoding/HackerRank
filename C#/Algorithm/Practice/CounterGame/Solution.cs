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

    /*
     * Complete the 'counterGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static string counterGame(long n)
    {
        // the key insight is that for powers of 2: 
        // the binary representation consists of only one bit set to 1 (all other bits are 0).
        // EX: 16 (binary: 10000) = 2^4 and 8 (binary: 1000) = 2^3
        // When you subtract 1 from a power of two,
        // you essentially flip all the 0s to 1s until the rightmost 1, 
        // and you change that rightmost 1 to 0
        // EX: 16 - 1 = 15 (binary: 01111) and 8 - 1 = 7 (binary: 0111)
        // When you AND a power of 2 with a power of 2 minus 1, you get 0.
        int count = 0;
        while (n > 1)
        {   
            // The point of using n -1 is to flip all the 0s to 1s until the rightmost 1
            // If we using ~n then we just simply flip all the bits and we will get the wrong result
            if ((n & (n - 1)) == 0) // check if n is a power of 2
            {
                n = n >> 1; // divide n by 2 by shifting all bits to the right by 1 
            }
            else
            {
                // Math.Log(n, 2) calculates the exponent to which 2 must be raised to get n. EX: Math.Log(16, 2) = 4
                n = n - (long)Math.Pow(2, (int)Math.Log(n, 2)); 
            }
            count++;
        }
        return count % 2 == 0 ? "Richard" : "Louise";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            string result = Result.counterGame(n);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
