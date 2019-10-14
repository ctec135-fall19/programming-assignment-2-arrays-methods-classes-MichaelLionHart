/*
Author:     Mike Hart
Date:       10/11/19
CTEC 135:   Microsoft Software Development with C#
Module 3,  Programming Assignment 2, Problem 2   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    // class demonstrates the use of methods, including calling by value,
    // calling by reference, and method overloading

    /*
    inputs:   myInt, myArray, float y, int x

    Outputs:  x, y, x-y

    Behavior: demonstrating call by value, call by reference, 
              and method overloading.
    */
    class Program
    {
        static void Main(string[] args)
        {            
            #region region 1: demo of call by value

            // create header
            Console.WriteLine("----------------Call by Value-------------\n");

            // create value
            int myInt = 65;

            // print statements that will help demonstrate this concept
            Console.WriteLine("Before method call:");
            Console.WriteLine("myInt: {0}", myInt);
            Console.WriteLine();
            Console.WriteLine("After method call:");
            callByValue(myInt);
            Console.WriteLine("myInt: {0}", myInt);
            Console.WriteLine();

            #endregion

            #region region 2: demo of call by reference

            // create header
            Console.WriteLine("-------------Call by Reference------------\n");

            // create array
            int[] myArray = new int[] { 10, 20, 30, 40, 50 };

            // print statements that will help demonstrate this concept
            // including for loops to print the array
            Console.WriteLine("Before method call:");            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("After method call:");
            callByReference(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine("\n");

            #endregion

            #region region 3: overloading

            // create header            
            Console.WriteLine("-------------Method Overloading------------\n");

            // code that demonstrates method overloading
            Console.WriteLine("45 - 42 = {0}", subtract(45, 42));
            Console.WriteLine("57 - 33.2 = {0}", subtract(57, 33.2f));
            Console.WriteLine();

            #endregion
        }

        // a static method that demonstrates call by value 
        static int callByValue(int x)
        {
            x = 10;
            return x;
        }

        // a static method that demonstrates call by reference
        static int[] callByReference(int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i * 7;
            }
            return y;
        }        

        // static methods that demonstrate method overloading
        static int subtract(int x, int y)
        {
            return x - y;
        }

        static float subtract(int x, float y)
        {
            return x - y;
        }
    }
}
