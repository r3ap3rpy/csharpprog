using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indoverload
{
    internal class Program
    {
        class Students { 
            private string[] _indexers = new string[10];
            public string this[int index] { 
                get { return _indexers[index]; }
                set { _indexers[index] = value; }
            }
        }
        class Guides { 
            private string[] _guideNames = new string[10];
            public string this[int index] {
                get { return _guideNames[index]; }
                set { _guideNames[index] = value; }
            }
            public string this[float id] {
                get { return _guideNames[1]; }
                set { _guideNames[1] = value; }
            }
            public string this[double id] {
                get { return "This is readonly"; }
                set {  }
            }
        }
        class MultiDim {
            private string[,] _guideNames = new string[10, 10];
            public string this[int x, int y] {
                get { return _guideNames[x, y]; }
                set { _guideNames[x, y] = value; }
            }
        }
        static void Main(string[] args)
        {
            Students elementarySchool = new Students();
            elementarySchool[0] = "Daniel";
            elementarySchool[1] = "Florian";
            elementarySchool[2] = "Noemi";
            for (int i = 0; i < 10; i++) { 
                Console.WriteLine(elementarySchool[i]);
            }
            //elementarySchool[10] = "Mother";
            Guides guides = new Guides();
            double k = 10.0;
            guides[0] = "Written!";
            guides[1.0f] = "Guides";
            Console.WriteLine(guides[k]);
            Console.WriteLine(guides[0]);
            Console.WriteLine(guides[0] + guides[1.0f]);

            MultiDim a = new MultiDim();
            a[0, 0] = "Daniel";
            a[0, 1] = "Florian";
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    if (a[i, j] == null) { Console.WriteLine($"[{i},{j}] = empty"); }
                    else { Console.WriteLine($"[{i},{j}] = empty"); }
                    
                }
            }

            Console.ReadKey();
        }
    }
}
