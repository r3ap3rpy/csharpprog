using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constvsreadonly
{
    class Student {
        public readonly string FullName;
        public Student(string name) { FullName = name; }
    }
    internal class Program
    {
        public readonly string compileTime = "Compile init!"; 
        static string TestConst() {
            const string test = "The value!";
            return test;
        }
        static void Main(string[] args)
        {
            const string myConstString = "This is a const string!";
            Console.WriteLine(myConstString);
            Console.WriteLine(TestConst());
            Student Daniel = new Student("Daniel");
            Console.WriteLine(Daniel.FullName);
            Console.ReadKey();
        }
    }
}
