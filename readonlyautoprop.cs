using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonlyautoproperties
{
    public class ServerField{
        readonly string _name;
        readonly string _function;
        public string Name { get => _name; }
        public string Function { get => _function; }
        public ServerField(string name, string function) {
            this._name = name;
            this._function = function;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerField a = new ServerField("AZAS1", "Domain Controller");
            Console.WriteLine(a.Name + " " + a.Function);
            //a.Name = "New Name";
            Console.ReadKey();
        }
    }
}
