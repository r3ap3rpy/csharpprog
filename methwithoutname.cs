using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate string StateReaction(string server, string state);
namespace methwithoutname
{
    
    internal class Program
    {
        public static string LinuxServer(string name, string state)
        {
            if (state == "up")
            { return "The server is up!"; }
            else if (state == "down")
            {
                return "The server is down!";
            }
            else { return "Unknown state!"; }
        }
        public static string WindowsServer(string name, string state)
        {
            return $"The server is in state {state}";
        }
        public delegate void State(string state);

        static void Main(string[] args)
        {
            StateReaction lin = new StateReaction(LinuxServer);
            StateReaction win = new StateReaction(WindowsServer);
            Console.WriteLine(lin("BIND", "up"));
            Console.WriteLine(lin("LDAP", "up"));
            Console.WriteLine(lin("DC", "up"));
            int outsideScope = 99;
            State s = delegate (string state)
            {
                Console.WriteLine($"The state: {state} was entered!");
                Console.WriteLine($"The value from outer scope is {outsideScope}");
            };
            s("up");
            Func<string, string> Welcome = name =>
            {
                return $"Welcome {name}";
            };
            Func<int, int> enTriple = x => x * 3;
            Console.WriteLine(Welcome("Daniel"));
            Console.WriteLine(enTriple(5));
            Console.ReadKey();
        }
    }
}
