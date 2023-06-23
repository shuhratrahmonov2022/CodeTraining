using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args) 
        {
            // exception = errors that occur during execution

            // try = try some code that is considered "dangerous"
            // catch = catches and handles exceptions when they occur
            // finally = always executes regaedless if exception is caught or not

            double x;
            double y;
            double result;
            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!"); ;
            }
            finally
            {
                Console.WriteLine("thanks for visiting!");
            }


        }
    }
}