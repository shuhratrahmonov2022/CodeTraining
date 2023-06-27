using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // generics = "not specific to a particular data type"
            //             add <T> to: classes, methods, fields, etc.
            //             allows for code reusabillity for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2","3" };

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(stringArray);

        }

        //public static void displayElement(int[] array) 
        //{
        //    foreach (int ietem in array)
        //    {
        //        Console.Write(ietem + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void displayElement(double[] array)
        //{
        //    foreach (double ietem in array)
        //    {
        //        Console.Write(ietem + " ");
        //    }
        //    Console.WriteLine();
        //}

        public static void displayElement<Thing>(Thing[] array)
        {
            foreach (Thing ietem in array)
            {
                Console.Write(ietem + " ");
            }
            Console.WriteLine();
        }
    }
}