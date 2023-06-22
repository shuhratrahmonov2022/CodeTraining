using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args) 
        {
            do
            { 
                double number1 = 0;
                double number2 = 0;
                double result = 0;

                Console.WriteLine("-----------------");
                Console.WriteLine("Calcultor Program");
                Console.WriteLine("-----------------");
                
                Console.Write("Enter number 1: ");
                number1 = Convert.ToDouble(Console.ReadLine());
               
                Console.Write("Enter number 2: ");
                number2 = Convert.ToDouble(Console.ReadLine());
               
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");
                
                switch (Console.ReadLine())
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"Your result: {number1}+{number2} = " + result);
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"Your result: {number1} - {number2} = " + result);
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"Your result: {number1} * {number2} = " + result);
                        break;
                    case "/":
                        result = number1 / number2;
                        Console.WriteLine($"Your result: {number1} / {number2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to again (Y = \"YES\", or N = \"NO\"): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
        }
    }
}