using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// static, instance variables, class instances, array elements,
// reference types (a.k.a. pointers)
// ref type : null
// built in integral numeric : 0
// float : 0
// bool : false
// char : \0
// enum : values produced by expression
// struct : all value-type fields are set to their own default
// nullable : default null value of value type
namespace AutoDefaultVal
{
    internal class Program
    {
        public string name { get; set; } = default;
        public int age { get; set; } = default;
        static void Main(string[] args)
        {
            int a = default(int);
            // after C# 7.1
            int b = default;
            int c = default;
            float d = default;
            double e = default;
            string f = default;
            var g = new System.Collections.ArrayList();
            Console.WriteLine($"The variable: {nameof(c)} has value {c}");
            Console.WriteLine($"The variable: {nameof(d)} has value {d}");
            Console.WriteLine($"The variable: {nameof(e)} has value {e}");
            Console.WriteLine($"The variable: {nameof(f)} has value {f}");
            Console.WriteLine($"The variable: {nameof(g)} has value {g}");
            Console.Read();
        }
    }
}
