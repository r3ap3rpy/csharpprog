using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Unary -- ++ + -
// Binary * / % + -
namespace Arithmeticncontext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int maximum = int.MaxValue;
                Console.WriteLine(maximum + 1);
            }
            
            
            Console.Read();
        }
    }
}
