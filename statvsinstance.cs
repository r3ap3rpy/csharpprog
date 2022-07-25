using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statvsnonstat
{
    public class NonStatic {
        public string member = "Whatever";
        public static string NoInstance() {
            return "I dont need no instantiation!";
        }
    }
    public class Counter {
        public static int instances = 0;
        public Counter() {
            instances += 1;
        }
    }
    internal class Program
    {
        public string AnotherNoInstance() {
            return "No instance here either!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NonStatic.NoInstance());
            Counter counter = new Counter();
            Console.WriteLine($"the number of instances: {Counter.instances}");
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();
            Console.WriteLine($"the number of instances: {Counter.instances}");
            Console.ReadKey();
        }
    }
}
