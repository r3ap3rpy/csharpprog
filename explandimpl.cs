using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplVsImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            //j = "Hello World!";
            //j = 10;
            //j = (int)10.0;
            int number = 128;
            double bigger = number;
            //derivedclass a = new derivedclass();
            //baseclass c = a;
            double mypi = 3.14;
            int a;
            a = (int)mypi;
            Console.WriteLine(a + " " + mypi);
            Console.ReadKey();
            //Opel o = new Opel();
            //Car c = o;
            //Opel oo = (Opel)c;

        }
    }
}
