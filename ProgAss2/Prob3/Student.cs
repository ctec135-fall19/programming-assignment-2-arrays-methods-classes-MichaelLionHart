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
    class Student
    {
        /*
        inputs:   create a name field and the associated set and get methods
                  create a ID property.Add validation code to the set method 
                  that ensures the value is between 100000 and 999999. 
                  create an automatic property for GPA..

        Outputs:  printState(), Throw an exception if the value is out of range.
        
        Behavior: creating fields and constructors to be testing by main.
                  Including an accessor and mutator method
        */

        // create a name field and the associated set and get methods
        private string studentName;
        private int studentID;

        // name accessor (get) method
        public string getName()
        {
            return studentName;
        }

        // name mutator (set) method
        public void setName(string name)
        {
            studentName = name;
        }

        // ID property. 
        public int ID
        {
            get { return studentID; }
            set {
                if (value < 100000 || value > 999999)
                {
                    throw new System.Exception("Input needs to be between 100,000 and 999,999");
                }
                else
                {
                    studentID = value;
                }
            }
        }

        // automatic property for GPA with an appropriate type.
        public double GPA { get; set; }

        // master constructor that has parameters 
        // for all three internal data elements
        public Student (string name, int id, double gpa)
        {
            studentName = name;
            studentID = id;
            GPA = gpa;
        }

        // constructor that has parameters
        // for name and ID and uses chaining
        public Student (string name, int id) : this(name, id, 0.0) {}

        // default constructor
        public Student()
        {
            studentName = "Mike Hart";
            studentID = 940282272;
            GPA = 5.0;
        }

        // PrintState() method
        public void printState()
        {
            Console.WriteLine("Student Name:\t{0}", studentName);
            Console.WriteLine("Student ID:\t{0}", studentID);
            Console.WriteLine("Student GPA:\t{0}", GPA);
        }
    }
}
