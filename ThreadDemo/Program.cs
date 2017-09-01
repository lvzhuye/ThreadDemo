using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }
        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
