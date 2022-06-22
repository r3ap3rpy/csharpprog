using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstCallChain
{
    public class NewEmployee {
        public string FirstName;
        public string LastName;
        public NewEmployee():this("Daniel","Szabo") {
            Console.WriteLine("Called without arguments!");
        }
        public NewEmployee(string firstName):this(firstName,"Szabo") { 
            this.FirstName = firstName;
            Console.WriteLine("Called with firstName argument!");
        }
        public NewEmployee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Console.WriteLine("Called with firstName and lastName argument!");
        }
    }
    public class ConstructMe {
        public string name;
        public int id;
        public ConstructMe(string name, int id){
            this.name = name;   
            this.id = id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructMe me = new ConstructMe("Daniel", 20);
            Console.WriteLine(me.name,me.id);
            NewEmployee a = new NewEmployee();
            NewEmployee b = new NewEmployee("Daniel");
            NewEmployee c = new NewEmployee("Danie", "Szabo");
            Console.Read();
        }
    }
}
