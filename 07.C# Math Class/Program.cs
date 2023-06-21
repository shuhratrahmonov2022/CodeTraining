using System;

namespace MatchClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 6;

           // double a = Math.Pow(x,2);
           // double b = Math.Sqrt(x);
           //double c = Math.Abs(x);
           //double c = Math.Round(x);
           //double c = Math.Ceiling(x);
           double c = Math.Floor(x);
           double d = Math.Max(x,y);
           double e = Math.Min(x,y);
            
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}