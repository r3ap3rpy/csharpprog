using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opnclosedgentypes
{   public class Device<T> { 
        public T name { get; set; }
        public T category { get; set; }
    }
    public class OG<T> {
        public enum OGEnum { 
        whohoo = 0
        }
    }
    public class Generic {
        public static object WillItRun() => typeof(OG<>.OGEnum).GetTypeInfo().GetDeclaredField("whohoo").GetValue(null);
        public static void Main() {
            Device<string> a = new Device<string>();
            Device<float> b = new Device<float>();
            a.name = "Domain Controller";
            a.category = "Testing";
            b.name = 1.0f;
            b.category = 2.0f;
            Console.WriteLine($"{a.name}, {a.category}");
            Console.WriteLine($"{b.name}, {b.category}");
            object foo = WillItRun();
            Console.WriteLine($"Is this an open generic? {foo.GetType().GetTypeInfo().IsGenericTypeDefinition}");
            Console.ReadKey();
        }
    }
}
