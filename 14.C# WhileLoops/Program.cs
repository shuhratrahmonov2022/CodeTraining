using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name);
        }
    }
}