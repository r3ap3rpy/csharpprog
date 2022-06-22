using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// number, string, bool, null reference
namespace ReadOnlyCoding
{
    internal class Program
    {
        private const string l = "Daniel";
        private const int salary = 100000;
        readonly string Name;
        readonly int Age;
        readonly int Salary;
        //public readonly DateTime DiplomaDate { get; }
        public Program() {
            Name = "Daniel";
            Age = 31;
            Salary = 120000;
        }
        public Program(string name, int age, int salary) {
            Name = name;
            Age = age;
            Salary = salary;
        }
        static void Main(string[] args)
        {
            const int n = 10;
            const string m = "Whatever";
            const double a = 1.0, b = 2.0, c = 3.0;
            Program g = new Program();
            Console.WriteLine($"{nameof(g)} holds {g.Name}, {g.Age}, {g.Salary}");
            Console.Read();
            //g.Name = "New Name";
        }
           
        }
    }

