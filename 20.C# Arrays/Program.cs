using System;

namespace Arrays
{
    class program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values, fixed size

            //tring[] cars = { "BMW", "Mustang", "Corvette" };

            String[] cars = new String[3];

            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}