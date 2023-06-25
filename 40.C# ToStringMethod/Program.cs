using System;

namespace ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            // ToString(0 = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());


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

        public override string ToString()
        {
            return "This is a "+ make+ " " + model + " "+ year + " " + color;
        }
    }
}