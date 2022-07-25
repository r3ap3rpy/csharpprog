using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notsosafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int* myIntPointer;
            //void* myVoidPointer;
            //int* myDamage, myHealth, myExperience;
            int[] a = new int[2] { 1, 2 };
            unsafe { 
            fixed (int* p = &a[0]) {
                int* p2 = p;
                Console.WriteLine(*p2);
                    *p += 1;
                    Console.WriteLine(*p);
            }
            }
            // ->, [], &, --, ++, ==
            Console.ReadKey();
        }
    }
}
