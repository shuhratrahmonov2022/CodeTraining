﻿using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants = immutable values which are known at compile time
            //             and do not change for the life of the program

            double pi = 3.14159;

            pi = 420;

            Console.WriteLine(pi);
        }
    }
}