using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args) 
        {   
            // static = modifier to declare a static member, which belongs to the class itself
            //          rether than to any specific object

            
            Car.numberOfCars = 10;
            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();
        }
    }

    static class Car
    {
        public static int numberOfCars;

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}