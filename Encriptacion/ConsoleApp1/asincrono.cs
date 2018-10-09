using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class asincrono
    {
        public void Proceso()
        {
            Random rnd = new Random();
            int i = rnd.Next(10);

            while (i > 0)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(500);
            }
        }
    }
}
