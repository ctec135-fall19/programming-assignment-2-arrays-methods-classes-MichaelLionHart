/*
Author:     Mike Hart
Date:       10/11/19
CTEC 135:   Microsoft Software Development with C#
Module 3,  Programming Assignment 2, Problem 3 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        /*
        inputs:   s, s1, s2

        Outputs:  printState(), Throw an exception if the value is out of range.
        
        Behavior: code that tests the accessor and mutator methods in the 
                  Student class, as well as the constructors that were coded
        */
        static void Main(string[] args)
        {
            #region region 1: demonstrate constructors

            // create header
            Console.WriteLine("------------Demonstrate Constructors---------\n");

            // demonstrate the use of each constructor. 
            // Print the state as necessary to show behavior.
            Student s = new Student();
            s.printState();
            Console.WriteLine();

            Student s1 = new Student("Mike Hart", 940282272);
            s1.printState();
            Console.WriteLine();

            Student s2 = new Student("Mike Hart", 940282272, 4.0);
            s2.printState();
            Console.WriteLine();

            #endregion

            #region region 2: demonstrate accessor and mutator

            // create header
            Console.WriteLine("---Accessor and Mutator of name field---\n");
             
            // demonstrate the accessor and mutator for the name field
            s.setName("Michael R. Hart");
            Console.WriteLine("Name: {0}", s.getName());
            Console.WriteLine();

            #endregion

            #region region 3: demonstrate use of properties

            // create header
            Console.WriteLine("------------Demonstrate Properties---------\n");

            // demonstrate the use of both properties
            s.ID = 902100;
            s.GPA = 3.84;
            s.printState();            
            Console.WriteLine();
            #endregion

            #region region 4: demonstrate exception

            // create header
            Console.WriteLine("------------Demonstrate Exceptions---------\n");

            // demonstrate a try/catch block that demonstrates 
            // the exception that was coded into the ID property 
            
            try
            {
                s.ID = 90210;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            s.printState();
            #endregion
        }
    }
}
