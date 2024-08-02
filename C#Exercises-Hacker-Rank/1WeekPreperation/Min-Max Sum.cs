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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        long minSum = long.MaxValue;
        long maxSum = long.MinValue;
        
        foreach (int num in arr){
            sum += num;
        }
        
        for(int i = 0; i< arr.Count; i++){
            long forSum = sum - arr[i];
            if(forSum < minSum){
                minSum = forSum;
            }
            if(forSum > maxSum){
                maxSum = forSum;
            }
        }
        
        Console.WriteLine("{0} {1}",minSum,maxSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
