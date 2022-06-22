using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            string b = "Hello World!";
            int c = 20;
            double d = 3.14;
            float f = 10;
            Console.WriteLine("a" + a + "b" + b + "c" + c + "d" + d + "f" + f);
            var greetings = "Welcome to C#!"; 
            Console.WriteLine(greetings);
            a = 99;
            Console.WriteLine("a" + a);
            Console.Read();
        }
    }
}
