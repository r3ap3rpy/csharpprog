using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// int, float, double, object, char, logical
// arithmetic, relational, logical,bitwise,
// assignment,conditional
namespace CompOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The size of int is: {sizeof(int)}");
            Console.WriteLine($"5 < 7 is {5 < 7}");
            Console.WriteLine($"5 > 7 is {5 > 7}");
            Console.WriteLine($"5 <= 7 is {5 <= 7}");
            Console.WriteLine($"5 >= 7 is {5 >= 7}");
            Console.WriteLine($"5 == 7 is {5 == 7}");
            Console.WriteLine($"5 != 7 is {5 != 7}");
            Console.Read();
        }
    }
}
