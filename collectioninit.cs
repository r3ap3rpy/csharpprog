using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers
{
    public class Server { 
        public string Name { get; set; }
        public string OS { get; set; }
        public string Tier { get; set; }
        public string Function { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Server WebServer = new Server();
            WebServer.Name = "Gatekeeper";
            WebServer.OS = "CentOS";
            WebServer.Tier = "Prod";
            WebServer.Function = "Proxy server";

            List<Server> srvrs = new List<Server>
            {
                new Server { Name = "GateKeeper", OS = "Linux", Tier = "Prod", Function="Proxy Server"},
                new Server { Name = "KeyHolder", OS = "Windows", Tier = "Prod", Function="Authentication Server"},
                new Server { Name = "GhostBuster", OS = "Windows", Tier = "Prod", Function="Antivirus Server"},
            };
            foreach(Server machine in srvrs)
            {
                Console.WriteLine($"The name: {machine.Name}, OS is {machine.OS}, function is {machine.Function} Tier is {machine.Tier}");
            }
            Console.Read();

        }
    }
}
