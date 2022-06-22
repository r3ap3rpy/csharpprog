using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynTypes
{
    public abstract class Base { }
    public class A1 : Base { }
    public class A2 : Base { }
    public class Test {
        public static void Main(string[] args) {
            Base a1 = new A1();
            Base a2 = new A2();
            Dispatcher(a1, a2);
            Dispatcher(a2, a1);
        }
        public static void Dispatcher(Base a1, Base a2) {
            dynamic x = a1;
            dynamic y = a2;
            Method(x, y);
            dynamic foo = 10;
            double sroot = Math.Sqrt(foo);
            Console.WriteLine(sroot);
            Console.Read();
        }
        public static void Method(A1 a1, A2 a2)
        {
            Console.WriteLine("(A1,A2)");
        }
        public static void Method(A2 a2, A1 a1)
        {
            Console.WriteLine("(A2, A1)");
        }
    }
    
}
