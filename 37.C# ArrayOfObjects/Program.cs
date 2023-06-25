using System;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
        }
    }

    class Car
    {
        public String model;

        public Car(String model) 
        {
            this.model = model;
        }
    }
}