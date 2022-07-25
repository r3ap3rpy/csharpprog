using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdefconv
{
    public class Conversions
    {
        public class CustomType { 
            public int Number { get; set; }
            public bool magic { get; set; }
            static public implicit operator CustomType(int value) {
                return new CustomType() { Number = value, magic = false };
            }
            static public explicit operator int(CustomType magic)
            { return magic.Number; }
        }
        static void Main(string[] args)
        {
            float pi = 3.14f;
            double dpi = pi;
            Console.WriteLine($"The {pi} and {dpi}");
            double ddpi = 3.14;
            float fdpi = (float)ddpi;
            Console.WriteLine($"The {ddpi} and {fdpi}");
            int aNumber = 3;
            CustomType magic = aNumber;
            Console.WriteLine($"From in {aNumber} int {magic} with value {magic.Number}");
            Console.ReadKey();
        }
    }
}
