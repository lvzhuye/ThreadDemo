using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "Worker";
            worker.Start();
            Go();
            //Thread.CurrentThread.Name = "main2";
            Thread.Sleep(10*1000);
        }

        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
    }
}
