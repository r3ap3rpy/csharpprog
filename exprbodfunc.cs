using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expbodfuncsynt
{
    public class Server {
        public string Name;
        private int _vCPU;
        private string _State;
        public string[] NetworkAdapters = new string[5];
        public string this[int i] { get => NetworkAdapters[i]; set => NetworkAdapters[i] = value; }
        public int vCPU { get => _vCPU; set => _vCPU = value; }
        public void Start() { Console.WriteLine("Booting up..."); _State = "Started"; }
        public Server(string name) => Name = name;
        ~Server() => Console.WriteLine("The end is neigh!");
    }
    public class ConstBody {
        public static void Main() {
            Server a = new Server("Domain Controller");
            a.vCPU = 10;
            Console.WriteLine(a.Name + " " + a.vCPU);
            Console.ReadKey();
        }
    }
}
