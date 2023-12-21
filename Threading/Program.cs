using System;
using System.Threading;
//a namespace called multithreading is created
namespace Threading
{
    //a class called mainthread is created under multithreading namespace
    class MainThread
    {
        //main method is called
        static void Main(string[] args)
        {
            //an instance of the thread class is created
            Thread thr = Thread.CurrentThread;

            //Name method of thread class is accessed using the instance of the thread class
            thr.Name = "Thread Class";

            //the content is displayed as the output
            Console.WriteLine("Welcome to {0}", thr.Name);




            Console.ReadKey();
        }
    }
}