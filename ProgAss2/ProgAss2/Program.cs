/*
Author:     Mike Hart
Date:       10/11/19
CTEC 135:   Microsoft Software Development with C#
Module 3,  Programming Assignment 2, Problem 1   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAss2
{
    class Program
    {
        /*
        inputs:   string[] myStringArray, int[] myIntArray
                  int[,] multiplicationTable

        Outputs:  ?

        Behavior: demonstrating and array of strings, and array
                  of integers, and a 2D array of a multiplication table
        */
        static void Main(string[] args)
        {
            #region region 1: array of strings

            // Heading
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("             Array of strings:");
            Console.WriteLine("-------------------------------------------");

            // create an array of strings of the first 
            // ten whole numbers (e.g. "one", "two", ..."ten")
            // Initialize the array using initialization syntax
            string[] myStringArray = new string[] { "one", "two", "three", 
                "four", "five", "six", "seven", "eight", "nine", "ten" };            

            // print the array using a foreach loop
            foreach (string number in myStringArray)
            {
                Console.WriteLine("{0} ", number);
            }
            Console.WriteLine();

            #endregion

            #region region 2: array of ints

            // Heading
            Console.WriteLine("-------------------------------------------");               
            Console.WriteLine("             Array of ints:");
            Console.WriteLine("-------------------------------------------");                

            // create an array of ints of size 10
            int[] myIntArray = new int[10];

            // initialize the array using a for loop 
            // with values being the index multiplied by 10
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i * 10;
            }

            // print the array using a for loop
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }
            Console.WriteLine();

            #endregion

            #region region 3: 2-D array

            // header
            Console.WriteLine("-------------------------------------------" +
                "-------------------------------------------------------\n");
            Console.WriteLine("                                 " +
                "      Multiplication Table:\b");            
            Console.WriteLine();
            
            // create a 2-D array that will hold the values 
            // of the multiplication table up to 12 x 12
            int[,] multiplicationTable = new int[13, 13];

            // initialize the array
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    multiplicationTable[i, j] = i * j;
                }
            }

            // creating column labeling
            Console.WriteLine("X\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\n\n" +
                "       -----------------------------------------------" +
                "---------------------------------------------");

            // print the array in a well-formatted manner
            for (int row = 1; row <= 12; row++)
            {
                Console.Write("{0}", row);
                for (int col = 1; col <= 12; col++)
                {
                    Console.Write("\t{0}", multiplicationTable[row, col]);
                }
                Console.WriteLine("\n       -----------------------------" +
                    "----------------------------------------------------" +
                    "-----------");
            }
            
            #endregion
        }
    }
}
