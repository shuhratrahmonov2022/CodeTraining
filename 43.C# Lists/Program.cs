using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of object that can be accessed by index.
            //        Simillar to array, but can dynamically increase.decrease in size
            //        using System.Collections.Generic.

            List<String> food = new List<string>();
            food.Add("pizza");
            food.Add("hanburger");
            food.Add("hotdog");
            food.Add("fries");
            food.Insert(0,"fries ");
            food.Remove("hanburger");
            food.Sort();
            food.Clear();
            String[] foodArray = food.ToArray();
            
 

            foreach (String doods in foodArray)
            {
                Console.WriteLine(doods);
            }
        }
    }
}