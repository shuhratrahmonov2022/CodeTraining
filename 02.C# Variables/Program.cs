using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) 
        {
            int x; //declaration
            x = 123; //initialization

            int y = 321; //declaration + initialization

            int age = 22; // whole integer
            double height = 300.5;
            bool alive = false; //true or false
            char symbol = '@';
            String name = "Code";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is  " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive?" + alive);
            Console.WriteLine("Your symbol is:" + symbol);

            string userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);
        }
    }
}