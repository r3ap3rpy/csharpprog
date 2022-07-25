using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
//[ attribute ( positional_parameters , name_parameter = value, … ) ] element
namespace compredattr
{
    internal class Program
    {   public class Server
        {
            private string _name;
            public string Name { get => _name; set => _name = value; }
            public Server(string name) { Name = name; }
            [Obsolete("Do not use UpdateServer() method, use UpdateAndRestart() instead!", false)]
            public void UpdateServer() { Console.WriteLine("Updating server!"); }
            public void RestartServer() { Console.WriteLine("Restarting server!"); }
            public void UpdateAndRestart() { Console.WriteLine($"Installing latest updates on machine: {Name} and restarting"); }
        }
        [AttributeUsage(AttributeTargets.Class)]
        class CompanyAttribute : Attribute {
            private string _name;
            private string _location;
            public string Name { get => _name; set => _name = value; }
            public string Location { get => _location; set => _location = value; }
            public CompanyAttribute(string company, string location) { Name = company; Location = location; }
        }
        [Company("Imaginary", "Atlantis")]
        class CompanyServer {
            private string _name;
            public string Name { get => _name; set => _name = value; }
            public CompanyServer(string name) { Name = name; }
            [Obsolete("Do not use UpdateServer() method, use UpdateAndRestart() instead!", false)]
            public void UpdateServer() { Console.WriteLine("Updating server!"); }
            public void RestartServer() { Console.WriteLine("Restarting server!"); }
            public void UpdateAndRestart() { Console.WriteLine($"Installing latest updates on machine: {Name} and restarting"); }
        }
        static void Main(string[] args)
        {
            CompanyServer a = new CompanyServer("Domain Controller");
            MemberInfo info = typeof(CompanyServer);
            object[] attrib = info.GetCustomAttributes(typeof(CompanyAttribute), false);
            foreach (Object attribute in attrib) {
                CompanyAttribute c = (CompanyAttribute)attribute;
                Console.WriteLine($"{c.Name}, {c.Location}");
            }
            Console.ReadKey();
        }
    }
}
