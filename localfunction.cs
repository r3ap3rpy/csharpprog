using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localfunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Message(string say) {
                Console.WriteLine(say);
            }
            Message("Welcome");
            int k = 11;
            double j = 99.9;
            void Scope(string x, int y) {
                Console.WriteLine($"The value of {nameof(x)} is {x}");
                Console.WriteLine($"The value of {nameof(y)} is {y}");
                Console.WriteLine($"The value of {nameof(k)} is {k}");
                Console.WriteLine($"The value of {nameof(j)} is {j}");
            }
            Scope("twelve", 99);
            void GenericFunction<Value>(Value x) {
                Console.WriteLine($"The value of {nameof(x)} is {x}");
            }
            GenericFunction(11.11);
            void MyOut(string x, out string s) {
                s = $"The value of {nameof(x)} is {x}";
            }
            string message = null;
            MyOut("twelve", out message);
            Console.WriteLine(message);
            void MyParams(params int[] array) {
                foreach (int element in array)
                {
                    Console.WriteLine($"Got the number of from the pipeline: {element}");
                }
            }
            int[] TestArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyParams(TestArray);
            Console.ReadKey();
        }
    }
}
