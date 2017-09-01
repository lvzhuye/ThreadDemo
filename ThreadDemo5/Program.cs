using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //int temp = i;
                new Thread(() => Console.Write(i)).Start();
            }
            Thread.Sleep(10000);
        }
    }
}
