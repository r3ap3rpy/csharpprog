using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace undgen
{
    internal class Program
    {
        static void OddProcessor(IEnumerator<int> i)
        {
            if (i.Current == 0)
            {
                Console.WriteLine("The list was processed, exiting!");
                Thread.Sleep(5);
                i.Dispose();
            }
            else if (i.Current % 2 == 0)
            {
                Console.WriteLine("The number is EVEN, calling processor.");
                EvenProcessor(i);

            }
            else if (i.Current % 2 != 0)
            {
                Console.WriteLine($"Processing odd: {i.Current}");
                Console.WriteLine("Odd number processed!");
                i.MoveNext();
                OddProcessor(i);
            }
            else
            { i.Dispose(); }
        }
        static void EvenProcessor(IEnumerator<int> i)
        {

            if (i.Current == 0)
            {
                Console.WriteLine("The list was processed, exiting!");
                Thread.Sleep(10);
                i.Dispose();
            }
            else if (i.Current % 2 != 0)
            {
                Console.WriteLine("The number is ODD, calling processor.");
                OddProcessor(i);
            }
            else if (i.Current % 2 == 0)
            {
                Console.WriteLine($"Processing even: {i.Current}");
                Console.WriteLine("Even number processed!");
                i.MoveNext();
                EvenProcessor(i);
            }
            else
            { i.Dispose(); }
        }
        static void Main(string[] args)
        {
            List<string> toBeIterated = new List<string>();
            IEnumerable<string> iEnumerabletoBeIterated = (IEnumerable<string>)toBeIterated;
            toBeIterated.Add("Programming");
            toBeIterated.Add("is");
            toBeIterated.Add("fun!");
            foreach (string element in iEnumerabletoBeIterated) { 
                Console.WriteLine(element);
            }
            List<int> myList = new List<int>(10);
            for (int i = 0; i < 10; i++) { myList.Add(i); }
            IEnumerator<int> myListEnum = myList.GetEnumerator();
            myListEnum.MoveNext();
            OddProcessor(myListEnum);

            Console.ReadKey();
        }   
    }
}
