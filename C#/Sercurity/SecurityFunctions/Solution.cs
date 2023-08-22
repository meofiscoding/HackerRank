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
     * Complete the 'calculate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER x as parameter.
     */

    public static int calculate(int x)
    {
        // return the remainder of x when divided by 11
        return x % 11;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int x = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.calculate(x);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
