using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructors = A special method in a class
            //                Same name as the class name
            //                Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Ford", "Mustang", 2023, "yellow");

            car1.Drive();
            car2.Drive();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + year);
        }
    }
}