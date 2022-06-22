using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;
using SW = System.IO.StreamWriter;
using UINT = System.Nullable<System.Int32>;
using UDBL = System.Nullable<System.Double>;
namespace namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C.WriteLine("Im coming form System.Console namespace.");
            var input = C.ReadLine();
            C.WriteLine($"You said {input}");
            C.Read();
            string[] linesToWrite = { "Written", "Spoken", "Heard" };
            using (SW myfile = new SW(@"C:\temp\myfile.txt")) {
                foreach (string line in linesToWrite) {
                    myfile.WriteLine(line);
                }
            }
        }
    }
}
