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
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     * The fact that an element (N - 1, N - 1) can be only in (0, 0), (N - 1, 0) or (0, N - 1) position.
     * Consider an (r, c) element. 
     One can observe that it can only be in one of the following four positions: (r, c), (N - r - 1, c), (r, N - c - 1) or (N - 1 - r, N - 1 - c)
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count / 2;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n ; j++)
            {
                sum += Math.Max(Math.Max(matrix[i][j], matrix[i][2 * n - 1 - j]), Math.Max(matrix[2 * n - 1 - i][j], matrix[2 * n - 1 - i][2 * n - 1 - j]));
            }
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
