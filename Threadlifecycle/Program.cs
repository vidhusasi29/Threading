using System;
using System.Diagnostics;
using System.Threading;

namespace Threadlifecycle

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create child thread
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            Console.WriteLine("Thread State: {0}", t1.ThreadState);
            // Start newly created thread
            t1.Start();
            Console.WriteLine("Thread State: {0}", t1.ThreadState);
            // Suspend thread
            try
            {


                t1.Suspend();
            }
            catch { }
            
            
            Console.WriteLine("Thread State: {0}", t1.ThreadState);
            // Resume thread to running state
            try
            {


                t1.Resume();
            }
            catch { }
            Console.WriteLine("Thread State: {0}", t1.ThreadState);
            Console.ReadLine();
        }
        static void PrintInfo()
        {
            Console.WriteLine("Method Execution");
        }
    }
}