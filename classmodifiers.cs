using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// public, protected, internal, private
// protected internal, private protected
// sealed
namespace ClassModifiers
{
    class Developer
    {
        private string Name;
        private int Salary;
        public Developer(string name, int salary)
        {
            Name = name; 
            Salary = salary;
        }
        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
                { this.Name = name; }
        }
        public string GetName() { return Name; }
        public void SetSalary(int amount)
        {
            if(amount.GetType() == typeof(int))
            {
                this.Salary = amount;
            }
        }
        public int GetSalary()
        { return this.Salary; }
    }
    public class InternalDemo
    {
        internal int number = 90;
    }
    public class PrivateDemo
    {
        private int number = 100;
    }
    public class ProtDemo
    {
        protected string secret = "Daniel";
    }
    public class Child : ProtDemo
    {
        public void print()
        {
            Console.WriteLine(secret);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer Daniel = new Developer("Szabo Daniel", 120000);
            PrivateDemo a = new PrivateDemo();

            Console.WriteLine(Daniel.GetName());
            //Console.WriteLine(a.number);
        }
    }
}
