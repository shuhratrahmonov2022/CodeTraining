using System;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple threads to platform,
            //          different tasks ofour program at the same time.
            //          Current thread running is "main" thread
            //          using System.Threading

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //   Console.WriteLine(mainThread.Name);
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();
        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
    }
}