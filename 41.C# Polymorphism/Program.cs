using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args) 
        {
            // polymorphism = Greek word that means to "have many forms
            //                Object can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();


            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    class Bicycle : Vehicle
    { 

    }

    class Boat : Vehicle
    { 

    }
}