using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace nullpropagop
{
    public class Server { 
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Server[] servers = new Server[5];
            Server S1 = new Server();
            S1.name = "First";
            Server S2 = new Server();
            S2.name = "Second";

            servers[0] = S1;
            servers[1] = S2;
            
            //foreach (Server s in servers) {
            //    Console.WriteLine(s.name);
            //}
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(servers?[i]?.name ?? "No name was specified!");
            }
            Console.ReadKey();
        }
    }
}
