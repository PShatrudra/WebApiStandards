using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace PracticeSample
{
    public static class TaskProblem
    {
        public static void SayHello()
        {
            Console.WriteLine("SayHello 1");

            Task task = new Task(() => { Console.WriteLine("SayHello 3"); Thread.Sleep(5000); });

            Console.WriteLine("SayHello 2");

            task.Start();

           
            Console.WriteLine("SayHello 4");

        }

        public static void SayHello2()
        {
            Console.WriteLine("SayHello 1");

            Task task = new Task(() => { Console.WriteLine("SayHello 3"); Thread.Sleep(5000); });

            Console.WriteLine("SayHello 2");

            task.Start();


            Console.WriteLine("SayHello 4");

        }
    }
}
