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
using Internal;

class Result
{

    /*
     * Complete the 'sumXor' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long sumXor(long n)
    {
        // Write your code here
        long count = 0;
        while (n > 0)
        {
            // count the number of position of 0s in binary string of n
            // each position of 0s can be 0 or 1 in binary string of x
            // because in XOR operation, 0 XOR 0 = 0 and 1 XOR 0 = 1, 1 XOR 1 = 0
            // So in addition, if n have bit 1 then x must have bit 0 correspondingly because if it is 1 then it will causing carry in result of next bit
            // EX: 1010 + 0010 = 1100 but 1010 XOR 0010 = 1000, the carry in result make the bit 1 become 0 and causing wrong result
            if (n % 2 == 0)
            {
                // we can know that when n % 2 == 0 then LSB will be 0
                // because when convert a number base 10 to base 2, the LSB will be 0 if the number is even and 1 if the number is odd
                // Example: Convert the decimal number 25 to binary.

                // Start with the decimal number 25.

                // Divide 25 by 2: 25 ÷ 2 = 12 remainder 1. Write down the remainder (1).

                // Divide 12 by 2: 12 ÷ 2 = 6 remainder 0. Write down the remainder (0).

                // Divide 6 by 2: 6 ÷ 2 = 3 remainder 0. Write down the remainder (0).

                // Divide 3 by 2: 3 ÷ 2 = 1 remainder 1. Write down the remainder (1).

                // Divide 1 by 2: 1 ÷ 2 = 0 remainder 1. Write down the remainder (1).

                // Now, write down the remainders in reverse order: 11001.
                count++;
            }
            // shift all bits to the right by 1 each time count the number of 0s in binary string of n
            n = n >> 1;
        }
        // using combination formula in mathematic, we can have 2^count number of x corresponding to n
        // EX: n = 4 (binary: 100) => count = 2 => 2^2 = 4 
        // => there are 4 possible number of x can be made from 2 places of 0s in binary string of n
        return (long)Math.Pow(2, count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.sumXor(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
