using System;

namespace AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto - Implemented properties = shortcut when no additional logic is required in the property 
            //                                 you do not have to define a field for a property,
            //                                 you only have to write get; and/or set; inside the property

            Car car = new Car("Porscha");
            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        public string Model { get; set; }
        public Car(String model)
        {
            this.Model = model;
        }
    }
}