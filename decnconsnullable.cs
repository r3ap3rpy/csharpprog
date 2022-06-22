using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decconsnulltypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? d = null;
            int? c = 9;
            int g = c ?? 99;
            double f = d ?? 99.9;
            if (d.HasValue) { Console.WriteLine($"The d has value of {d.Value}"); }
             Console.WriteLine($"The f has value of {f}");
            Console.Read();
        }
    }
}
