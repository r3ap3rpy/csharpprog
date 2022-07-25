using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeinference
{
    public class Server { 
        public string Name { get; set; }
        public string OS { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Server> servers = new List<Server>
            {
                new Server { Name ="Parabellum", OS="Win2019"},
                new Server { Name ="BigBoy", OS="Centos8"},
                new Server { Name ="Rikimaru", OS="Debian9"}
            };
            var ServerQuery = from server in servers where server.OS == "Debian9" select new { server.Name, server.OS};
            foreach (var server in ServerQuery) {
                Console.WriteLine(server);
            }
            Console.ReadKey();
        }
    }
}
