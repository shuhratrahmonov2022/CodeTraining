using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) 
        {
            // method = performs a section of code, whenever it`s called "invoked".
            //          benefit = Let`s us reuse code w/o writing it multiple times

            String name = "Code";
            int age = 22;

            singHappyBirthday(name,age);

        }

        static void singHappyBirthday(String birthdayBoy, int yearsAge)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear "+ birthdayBoy);
            Console.WriteLine("You are " + yearsAge + "years old!");
            Console.WriteLine();
        }
    }
}