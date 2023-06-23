using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args) 
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Code";
            String LastName = "CodeC#";
            int age = 21;

            //Console.WriteLine("Hello " + firstName + " " + LastName + ".");
            //Console.WriteLine("You are " + age + "years old.");

            Console.WriteLine($"Hello {firstName} {LastName}.");
            Console.WriteLine($"You are {age} old");
        }
    }
}