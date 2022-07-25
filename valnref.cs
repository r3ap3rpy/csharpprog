using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valnref
{

 
    internal class Program
    {
        public class Server
        {
            public string type;
            public int cpu;
            public double ram;
        }
        public static void SquareIt(double x)
        {
            Console.WriteLine(x * x);
        }
        public static void InitializeServer(string category, Server s) {
            if (category == "small")
            {
                s.type = "small";
                s.cpu = 1;
                s.ram = 2;
            }
            else if (category == "medium")
            {
                s.type = "medium";
                s.cpu = 2;
                s.ram = 4;
            }
            else if (category == "big")
            {
                s.type = "big";
                s.cpu = 4;
                s.ram = 8;
            }
            else { throw new System.ArgumentException("Category must be small, medium or big!"); }
        }
        static void Main(string[] args)
        {
            double a = 10;
            SquareIt(a);
            Server b = new Server();
            InitializeServer("small",b);
            Console.WriteLine($"{b.cpu} - {b.type} - {b.ram}");
            Console.ReadKey();
        }
    }
}
