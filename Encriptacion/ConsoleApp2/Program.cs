using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread x = new Thread(proceso);
            Thread y = new Thread(proceso);

            x.Start("hilo 1");
            y.Start("hilo 2");

            while (x.IsAlive || y.IsAlive) ;
            x.Abort();
            y.Abort();
        }

        public static void proceso(object nombre)
        {
            Random rnd = new Random();
            double i = rnd.Next(10);
            while (i > 0)
            {
                Console.WriteLine("{0}=> {1}", nombre, i.ToString());
                Thread.Sleep(430);
                i = rnd.Next(10);

            }
        }
        
    }
}
