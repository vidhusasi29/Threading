using System;
using System.Threading;
namespace Threading2
{



    class Program
    {

        public static void Main()
        {

            //Creates thread objects

            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);

            thread1.Start();
            
            thread2.Start();

        }

        static void Method1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method One Executed " + i.ToString());
                Thread.Sleep(4000); //Sleep for 4 seconds




            }
        }

        static void Method2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method Two Executed " + i.ToString());
                Thread.Sleep(4000); //Sleep for 4 seconds

            }
        }
    }

}