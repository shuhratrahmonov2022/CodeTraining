﻿using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}
            //int i = 0;

            //while (i < rows)
            //{
            //    i++;

            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();

            //}

            for (int i = 0; i < rows; i++)
            {
                int j = 0;
                while (j < columns)
                {
                    j++;
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}