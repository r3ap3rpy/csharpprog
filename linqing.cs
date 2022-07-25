using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqlazy
{   public class Server {
        string _name;
        string _function;
        public string Name { get => _name; set => _name = value; }
        public string Function { get => _function; set => _function = value; }
        public Server(string name, string function) { _function = function; _name = name; }
    }
    internal class Program
    { public static IEnumerable<Server> ServerDB() {
            Server[] servers = new Server[] {
                new Server("Parabellum","Domain Controller"),
                new Server("Whatever","DHCP"),
                new Server("Wherever","DNS")
            };
            foreach (Server s in servers) {
                yield return s;
            }
        }
        
        static void Main(string[] args)
        {
            IList<string> serverList = new List<string>() {
            "Parabellum - Domain Controller",
            "Prostethic - DNS",
            "Spooky - DHCP"
            };
            var DCS = serverList.Where(s => s.Contains("Domain Controller"));
            Console.WriteLine(DCS);
            foreach (Server s in ServerDB()) {
                Console.WriteLine($"{s.Name} -> {s.Function}");
            }
            Console.ReadKey();
        }
    }
}
