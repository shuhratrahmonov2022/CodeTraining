using System;

namespace ReturnKeyWord
{
    class Program
    {
        static void Main(string[] args) 
        {
            //return = returns data back to the place where a method is invoked

            double x;
            double y;
            double result;

            Console.Write("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine("Result: " + result);
        }

        static double Multiply(double x, double y)
        {
            return x * y; 
        }
    }
}