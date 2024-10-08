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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void plusMinus(List<int> arr)
    {
        int size = arr.Count;
        int countPositive = 0;
        int countNegative = 0;
        int countZero = 0;
        
        for(int i = 0; i<size; i++){
            if(arr[i]<0){
                countNegative++;
            } else if (arr[i]>0){
                countPositive++;
            } else {
                countZero++;
            }
        }
        
        Console.WriteLine((float)countPositive/size);
        Console.WriteLine((float)countNegative/size);
        Console.WriteLine((float)countZero/size);
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
