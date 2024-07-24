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
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int x)
    {
        for(int n = 1; n <= x; n++)
        {
            if(n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");  
            }
            else if(n % 3 == 0 && n % 5 != 0)
            {
                Console.WriteLine("Fizz");  
            }
            else if(n % 3 != 0 && n % 5 == 0)
            {
                Console.WriteLine("Buzz");  
            }
            else
            {
                Console.WriteLine(n);  
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
