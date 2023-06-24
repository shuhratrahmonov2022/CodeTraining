using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();
            human1.name = "Shuhrat";
            human1.age = 22;

            human2.name = "Rahmonov";
            human2.age = 22;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

    }
}