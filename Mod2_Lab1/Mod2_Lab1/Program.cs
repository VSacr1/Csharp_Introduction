﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an if decision block
            // use this if block to check for an even number

            //request user input with ReadLine()
            Console.WriteLine("Please enter an integer value and press enter");

            //Assign the entered value to the variable input
            //convert image to integer before using 
            int input = Int32.Parse(Console.ReadLine());

            //Check to see if the number is even 
            //Here we use the simple task of checking for a remainder when dividing by 2
            //The (%) or modulus operator returns the remainder of integer
            //If the remainder is 0, then the value is able to be divided by 2
            //no remainder, which means it is an even number
            if(input % 2 == 0)
            {
                Console.WriteLine("The entered number was an even number");
            }
            else
            {
                Console.WriteLine("The entered number was an odd number");
            }
        }
    }
}
