using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Tuple<T1, T2, T3, T4....>
namespace DecConsTuples
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string> MyStringTuple = new Tuple<string>("Pluralsight");
            Tuple<string, int> MyCustomTuple = new Tuple<string, int>("Daniel", 20);
            Tuple<int, int, int, int, int, int, int, Tuple<int>> MyMaxTuple = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));
            Console.WriteLine($"The {nameof(MyStringTuple)} has the following elements: {MyStringTuple}");
            Console.WriteLine($"The {nameof(MyCustomTuple)} has the following elements: {MyCustomTuple}");
            Console.WriteLine($"The {nameof(MyMaxTuple)} has the following elements: {MyMaxTuple}");
            var MsT = Tuple.Create("String Tuple");
            var McT = Tuple.Create("Daniel", 30);
            Console.WriteLine(McT.Item1);
            Console.WriteLine(McT.Item2);
            var MyMaxTupleNested = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20, 21)));
            Console.WriteLine($"Second level of nesting: {MyMaxTupleNested.Rest.Item1.Rest.Item1}");

            Console.Read();
        }
    }
}
