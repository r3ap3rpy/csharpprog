#define DEV
#if PROD
#undef DEBUG
#undef TRACE
#endif
#if !PROD && !TEST && !DEV
#error Cannot compile!
#else
#warning Running with hardcoded tier!
#endif
#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace preprocdir
{
#line 1 "Warning line.cs"
#pragma warning disable CS3020
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
System.Console.WriteLine("Debug mode!");
#else
System.Console.WriteLine("No debug!");
#endif
            System.Console.ReadKey();
        }
    }
}
