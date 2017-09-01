using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() => {
                Console.WriteLine("I'm running on another thread!");
                Console.WriteLine("This is so easy!");
            }).Start();

            new Thread(delegate()
            {
                Console.WriteLine("T'm runing on another thread!");
                Console.WriteLine("This is so easy!");
            }).Start();
            Thread.Sleep(10000);
        }
    }
}
