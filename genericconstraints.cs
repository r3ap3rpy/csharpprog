using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//where T : struct, the argument must be a value type except Nullable
//where T : class, the argument must be a reference type, applies to classes, interfaces and delegates, even arrays
//where T : notnull, the argument must be non-nullable
//where T : unmanaged, the argument must be an unmanaged type, a.k.a. pointers and unsafe code.
//where T : base -class, the argument must be derived from a base class of type, or base class itself
//where T : new(), the argument must have a parameterless constructor, which is public
//where T: interface, the argument must be or implement a specified interface
//where T: U, the argument must be or derived from the argument supplied for U.
namespace genparconstr
{
    //public class GenericArray(T){
    //  public void Summarize(T input);
    //}
    class GenericClass<T> where T : class {
        private readonly T _field;
        public GenericClass(T value) {
            this._field = value;
        }
        public T genericMethod(T parameter) {
            Console.WriteLine($"The type fo the parameter is {typeof(T)}, value is {parameter}");
            Console.WriteLine($"The return type of parameter is {typeof(T)}, value {this._field}");
            return this._field;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> a = new GenericClass<string>("Hello World!");
            a.genericMethod("string");
            Console.ReadKey();
        //GenericArray<int> myFloatGenericArray = new GenericArray<int>();
    }
    }
}
