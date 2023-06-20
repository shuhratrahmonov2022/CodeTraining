using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) 
        {
            // type casting = Converting a value to a different data type 
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(j);
            Console.WriteLine(h.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
        }
    }
}