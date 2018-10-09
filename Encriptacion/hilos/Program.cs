using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Asincrono hilo = new Asincrono();
            Thread p = new Thread(new ThreadStart(hilo.Proceso));
            p.Start();
            while (p.IsAlive) ;
            Console.WriteLine("proceso terminado");
            Console.ReadLine();
        }
    }
}
