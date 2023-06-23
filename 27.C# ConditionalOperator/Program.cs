using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y;

            double temperature = 20;
            Console.WriteLine((temperature >= 15) ? "It`s warm outside!" : "It`s cold outside!");
        }
    }
}
