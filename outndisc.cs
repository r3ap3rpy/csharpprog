using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outndisc
{
    internal class Program
    {
        public static string SLA(double a, double b, out double result, out string sla) { 
            result = Math.Round((b /a) * 100,2);
            sla = $"Total hours: {a}, available hours: {b}, SLA: {result}";
            return sla;
        }
        public static void prs(string dtstr) {
            if (DateTime.TryParse(dtstr, out _)) {
                Console.WriteLine("Date is valid!");
            } else {
                Console.WriteLine("Date is InValid!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{SLA(10, 8, out double result, out string sla)}");

            var tuple = (1, 2, 3, 4, 5);
            (_, var first, _, var second, _) = tuple;
            Console.WriteLine(first + " " + second);
            prs("02/29/2022");
            Console.ReadKey();
        }

    }
}
