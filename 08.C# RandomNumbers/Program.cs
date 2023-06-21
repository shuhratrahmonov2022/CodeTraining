using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number1 = random.Next(1, 7)+101;
            int number2 = random.Next(1, 7);
            int number3 = random.Next(1, 7);
            double num = random.NextDouble();

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(num);
        }
    }
}