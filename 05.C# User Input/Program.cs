using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s yout name?");
            String name = Console.ReadLine();

            Console.WriteLine("What`s your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your are  " + age + " Years old");
        }
    }
}