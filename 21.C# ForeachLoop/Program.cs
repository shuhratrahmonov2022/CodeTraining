using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate over an array, but it`s less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

}