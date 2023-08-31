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
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
        // Write your code here
        int count = 0;
        if (s.Length % 2 == 0)
        {
            string s1 = s.Substring(0, s.Length / 2);
            string s2 = s.Substring(s.Length / 2);
            int[] countChar = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                countChar[s1[i] - 'a']++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                countChar[s2[i] - 'a']--;
            }
            foreach (int item in countChar)
            {
                if (item > 0)
                {
                    count += item;
                }
            }
        }
        else
        {
            count = -1;
        }
        return count;
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

            int result = Result.anagram(s);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
