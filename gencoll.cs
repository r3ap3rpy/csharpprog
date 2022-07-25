using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenColl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10);
            Hashtable myHash = new Hashtable();
            myHash.Add("Skillshare", "First");
            myHash.Add("Pluralsight", "Second");
            foreach (DictionaryEntry d in myHash) {
                Console.WriteLine($"{d.Key} = {d.Value}");
            }
            ArrayList myList2 = new ArrayList();
            myList2.Add(1);
            myList2.Add(2);
            myList2.Add("Daniel");
            foreach (object element in myList2) {
                Console.WriteLine(element);
            }
            int a = 99;
            object b = a;
            int c = (int)b;
            Console.WriteLine(c + " " + b + " " + a);
            Console.ReadKey();
        }
    }
}
