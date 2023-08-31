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
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int palindromeIndex(string s)
    {
        // Write your code here
        int index = -1;
        int length = s.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (s[i] != s[length - i - 1])
            {
                if (s[i + 1] == s[length - i - 1] && s[i + 2] == s[length - i - 2])
                {
                    index = i;
                }
                else
                {
                    index = length - i - 1;
                }
                break;
            }
        }
        return index;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
