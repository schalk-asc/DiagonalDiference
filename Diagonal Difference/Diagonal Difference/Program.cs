﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    internal class Program
    {

        class Result
        {

            /*
             * Complete the 'diagonalDifference' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts 2D_INTEGER_ARRAY arr as parameter.
             */

            public static int diagonalDifference(List<List<int>> arr)
            {
                int Arraysize = (int)Math.Sqrt(arr.Count);

                int val1 = 0;
                int val2 = 0;


                for (int i = 0; i < arr.Count; i++)
                {
                    val1 = val1 + arr[i][i];
                    val2 = val2 + arr[i][arr.Count - 1 - i];
                }

                Console.WriteLine(val1 + " " + val2);

                return Math.Abs(val1 - val2);
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<List<int>> arr = new List<List<int>>();

            //    for (int i = 0; i < n; i++)
            //    {
            //        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //    }

            //    int result = Result.diagonalDifference(arr);

            //    textWriter.WriteLine(result);

            //    textWriter.Flush();
            //    textWriter.Close();
            }
        }




    }
}
