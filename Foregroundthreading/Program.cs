using System;
using System.Threading;

namespace Foregroundthreading

{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            t1.Start();
            Console.WriteLine("Main Thread Execution Completed");
        }
        static void PrintInfo()
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Child Thread Execution Completed");
        }
    }
}