using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// try, catch, finally
namespace excceptionfiltering
{
    public class MyException : Exception { 
        public MyException() { }
        public MyException(string message) : base(message) { }
    }
    internal class Program
    {
        static double Divide(double a, double b) {
            if (b == 0)
            { throw new MyException("This is not what I expected!"); }
            if (b == 10)
            { throw new MyException("The second value is exactly 10%"); }
            return a / b;
        }
        static void Main(string[] args)
        {
            try { Console.WriteLine(Divide(10.0, 0)); }
            catch { Console.WriteLine("This is not what I expected!"); }
            finally { Console.WriteLine("Im going to be executed anyway!"); }

            try { Console.WriteLine(Divide(10.0, 0)); }
            catch (MyException e) when (e.Message.Contains("expected")) 
            { Console.WriteLine("This is not what I expected!"); }
            catch (Exception e) 
            { Console.WriteLine("This is not what I expected!"); }
            finally { Console.WriteLine("Im going to be executed anyway!"); }
            Console.ReadKey();
        }
    }
}
