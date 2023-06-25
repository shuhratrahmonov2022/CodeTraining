using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. form a common parent

            Car car = new Car();
            
            Bicycle bicycle = new Bicycle();

            Boat boat = new Boat();

            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.wheels);
            boat.go();
            Console.WriteLine(boat.speed);
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Car
    {
        public int wheels = 0;
    }
}
