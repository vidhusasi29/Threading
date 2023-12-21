using System;
using System.Threading;

namespace Backgroundthreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            t1.Start();
            t1.IsBackground = true;
            Console.WriteLine("Main Thread Execution Completed");
        }
        static void PrintInfo()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Child Thread Execution Completed");
        }
    }
}