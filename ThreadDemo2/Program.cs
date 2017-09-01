using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => Print("Hello form t!"));
            t.Start();
            t.Join();
        }

        static void Print(string message)
        {
           Console.Write(message);
        }
    }
}
