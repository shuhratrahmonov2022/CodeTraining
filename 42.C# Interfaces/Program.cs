using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class definess "how it should do it"

            //             Benefit = security + multiple inheritance + "plug - and play"

            Rabbit rabbit = new Rabbit();
            rabbit.Fleep();
            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Fleep();
            fish.Hunt();

        }
    }

    interface IPrey
    {
        void Fleep();
    }

    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Fleep()
        {
            Console.WriteLine("The Rabbit runs away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Fleep()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }
}
