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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        // Đếm tất cả các số x sao cho:
        // Tất cả các phần tử trong a phải là ước của x, ví dụ: x % a[i] == 0 (a[i] phải nhân với 1 số nào đấy để bằng x)
        // Tất cả các phần tử trong b phải chia hết cho x, ví dụ: b[i] % x == 0 (x phải nhân với 1 số nào đấy để bằng b[i])
        int count = 0;
        int maxA = a.Max();
        int minB = b.Min();
        for (int i = maxA; i <= minB; i++)
        {
            bool isFactor = true;
            foreach (int item in a)
            {
                if (i % item != 0)
                {
                    isFactor = false;
                    break;
                }
            }
            if (isFactor)
            {
                foreach (int item in b)
                {
                    if (item % i != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }
            }
            if (isFactor)
            {
                count++;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        //textWriter.WriteLine(total);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
