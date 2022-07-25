using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clojuresnlambda
{
    public static partial class ClosureDemo { 
        public static void Outside() {
            string notlocal = "Closure based lambda!";
            Func<string> demo = () =>
            {
                string local = "This is lambda!";
                return local + notlocal;
            };
            string message = demo();
            Console.WriteLine(message);
        }
    }
    internal class Program
    {
        static string best = "Daniel";
        static void WhoIsTheBest()
        {
            Console.WriteLine($"{best} is the best!");
        }
        static void Main(string[] args)
        {
            //Func<double, double, bool> isItEqual = (x,y) => x == y;
            //Action<string> Welcome = name =>
            //{
                //Console.WriteLine($"Welcome {name} to the platform!");
            //};
            WhoIsTheBest();
            ClosureDemo.Outside();
            int foo = 10;
            Func<int> Bar = () => { return foo; };
            Console.WriteLine($"Foo: {Bar()}");
            foo = 20;
            int figther = Bar();
            Console.WriteLine($"Fighter: {figther}");
            Console.ReadKey();
        }
    }
}
