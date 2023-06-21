using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Shuhrati";
            String PhoneNumber = "123-456-789";

            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            PhoneNumber = PhoneNumber.Replace("-", "/");
            Console.WriteLine(PhoneNumber);
            String UserName = fullName.Insert(0, "Mr.");
            Console.WriteLine(UserName);
            Console.WriteLine(fullName.Length);
            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(3, 5);
            Console.WriteLine(firstName);
           
            Console.WriteLine(lastName);
        }      
    }
}