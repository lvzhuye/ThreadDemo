using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread worker = new Thread(() => { try {
                Thread.Sleep(4000);
                throw new Exception("test"); }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.WriteLine("test2"); }
            });
            if (args.Length > 0) worker.IsBackground = true;
            worker.Start();
            Thread.Sleep(3900);
        }
    }
}
