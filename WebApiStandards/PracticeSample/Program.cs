using System;
using System.Threading;

namespace PracticeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Entry!");

            //TaskProblem.SayHello();

            //Console.WriteLine("Exit!");

            //Thread.Sleep(10000);


            //2.0

            Console.WriteLine("Entry!");

            Thread thread = new Thread(new ThreadStart(TaskProblem.SayHello));

            thread.Start();

            Console.WriteLine("Exit!");

            Console.Read();
        }
    }
}
