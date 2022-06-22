using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumnyield
{
    
    internal class Program
    {
        public static List<int> EvenNumbers(int max)
        {
            var retList = new List<int>();
            int i = 0;
            while (retList.Count < max)
            {
                retList.Add(i += 2);
            }
            return retList;
        }
        public static IEnumerable<int> OddNumbers(int max)
        {

            int i = 1;
            while (i < (max * 2))
            {
                yield return i;
                i += 2;
            }
        }
        static void Main(string[] args)
        {
            //foreach (int i in EvenNumbers(10000)) { 
            //    Console.WriteLine(i);
            //}
            foreach(int i in OddNumbers(1000).Take(10))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
