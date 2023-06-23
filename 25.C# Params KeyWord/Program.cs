using System;

namespace ParamsKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single - dimensional array

            double total = CheckOut(2.3, 33.3,3.22,3.99, 5.75);
            Console.WriteLine(total);
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}