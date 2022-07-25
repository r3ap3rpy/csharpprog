using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bell-> '\a'
//backspace-> '\b'
//formfeed-> '\f'
//carriage return -> '\r'
//new line -> '\n'
//horizontal tab -> '\t'
//vertical tab -> '\v'
//single quote -> '''
//double quote -> '"'
//backslash -> '\'
namespace syntaxforliterals
{
    internal class Program
    {
        //stylecop
        //resharper
        static void Main(string[] args)
        {
            int a = 28;
            int o = 012;
            int h = 0x1C;
            double da = 28.3848;
            double db = 27E-5;
            double dc = 28f;
            char c = 'a';
            char cu = '\u0306';
            string s = "Welcome!";
            bool b = true;
            Console.WriteLine($"The variable {nameof(a)} has value {a}");
            Console.WriteLine($"The variable {nameof(o)} has value {o}");
            Console.WriteLine($"The variable {nameof(h)} has value {h}");
            Console.WriteLine($"The variable {nameof(da)} has value {da}");
            Console.WriteLine($"The variable {nameof(db)} has value {db}");
            Console.WriteLine($"The variable {nameof(dc)} has value {dc}");
            Console.WriteLine($"The variable {nameof(c)} has value {c}");
            Console.WriteLine($"The variable {nameof(cu)} has value {cu}");
            Console.WriteLine($"The variable {nameof(s)} has value {s}");
            Console.WriteLine($"The variable {nameof(b)} has value {b}");
            Console.ReadKey();
        }
    }
}
