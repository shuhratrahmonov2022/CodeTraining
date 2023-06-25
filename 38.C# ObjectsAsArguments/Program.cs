using System;
using System.ComponentModel.DataAnnotations;

namespace ObjectsAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang","red");
            Car car2 = Copy(car1);

            Console.WriteLine(car2.color + " " + car2.model);

        }
        public static Car Copy(Car car)
        {
            return new Car(car.color, car.model);
        }
    }

    class Car
    {
        public String model;
        public String color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}