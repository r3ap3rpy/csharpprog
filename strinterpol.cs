using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringinterpol
{
    internal class Program
    {
        static int FourthPower(int x) {
            return x * x * x * x;
        }
        static void Main(string[] args)
        {
            string where = "Tesco";
            string what = "Tomato";
            int[] even = { 2, 4, 6, 8 };
            Console.WriteLine($"I bought {what} in {where}");
            Console.WriteLine($"The {even[0]}, {even[1]}, {even[2]}, {even[3]} are even numbers!");
            int x = 8;
            int y = 10;
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} to the 4th power is = {FourthPower(x)}");
            var workers = new Dictionary<string, string>() { 
                ["John Doe"] = "Devops",
                ["Doe John"] = "Developer"
            };
            Console.WriteLine($"|{"Worker",-16}|{"Position",20}|");
            foreach (var title in workers) {
                Console.WriteLine($"|{title.Key,-16}|{title.Value,20}|");
            }
            Console.ReadKey();
        }
    }
}
