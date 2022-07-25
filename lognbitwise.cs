using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalAndBitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!a);
            int c = 6;
            int d = 17;
            // 6 -> 0000 0110
            // 17 -> 0001 0001
            Console.WriteLine(Convert.ToString((c|d)));
            Console.WriteLine(Convert.ToString((c & d)));
            Console.WriteLine(Convert.ToString(~c));
            Console.WriteLine(Convert.ToString(c^d));
            Console.ReadKey();
        }
    }
}
