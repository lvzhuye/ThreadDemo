using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo1
{

    class Program
    {
        static int i;
        static void Main(string[] args)
        {
            //Thread t = new Thread(new ThreadStart(Go));
            for (int J = 0; J < 1000; J++)
            {
                Thread t = new Thread(() => i++);
                t.Start();
            }

            Go();
            Thread.Sleep(200000);
            Console.Write(i);
        }

        static void Go()
        {
            i++;
        }
    }
}
