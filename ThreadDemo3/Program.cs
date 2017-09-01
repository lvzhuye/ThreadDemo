using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Print);
            t.Start("Hello from t!");
            Thread.Sleep(10000);
        }

        static void Print(object messageObj)
        {
            string message = (string)messageObj;
            Console.WriteLine(message);
        }
    }
}
