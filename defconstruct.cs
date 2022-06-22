using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defconstninvoc
{
    public class Program
    {
        bool isInitalized;
        private int a;
        private int b;
        public Program() {
            Console.WriteLine("Constructor without arguments!");
            isInitalized = true;
        }
        public Program(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"The instance was initialized with {this.a} and {this.b}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Program program1 = new Program(1,2);
            Console.WriteLine($"The value {program.a} and {program.b}");
            Console.Read();
        }
    }
}
